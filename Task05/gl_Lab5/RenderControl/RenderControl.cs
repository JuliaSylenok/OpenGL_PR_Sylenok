using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace gl_Lab5
{
    public partial class RenderControl : OpenGL
    {
        private bool isWireframe = true;
        public bool IsWireframe
        {
            get => isWireframe;
            set
            {
                isWireframe = value;
                Invalidate(); 
            }
        }
        private bool orthoPerstective = true;
        public bool OrthoPerspective
        {
            get => orthoPerstective;
            set
            {
                orthoPerstective = value;
                Invalidate(); 
            }
        }
        public int segments = 15;
        
        public double sphereRadius = 1.5;
        
        public double cylinderRadius = 2.5;
        public double cylinderHeight = 1.5;
        
        public double diskInnerRadius = 1.0;
        public double diskOuterRadius = 3.5;
        public int diskStartAngle = 180;
        public int diskSweepAngle = 135;


        double size = 6.0;
        double AspectRatio { get => (double)Width / Height; }
        double xMin { get => (AspectRatio > 1) ? -size * AspectRatio : -size; }
        double xMax { get => (AspectRatio > 1) ? +size * AspectRatio : +size; }
        double yMin { get => (AspectRatio < 1) ? -size / AspectRatio : -size; }
        double yMax { get => (AspectRatio < 1) ? +size / AspectRatio : +size; }

        double zMin { get => -size; }
        double zMax { get => +size; }
        double ax = 10, ay = -20;
        double sphereX = 2.5, sphereY = 1.0, sphereZ = -3.5;
        double cylinderX = -2.5, cylinderY = -3.5, cylinderZ = -4.5;

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            if (orthoPerstective)
                glOrtho(xMin, xMax, yMin, yMax, zMin, zMax);
            else
            {
                glMatrixMode(GL_PROJECTION);
                glLoadIdentity();
                gluPerspective(45.0, AspectRatio, 1.0, 50.0);
                glMatrixMode(GL_MODELVIEW);
                glLoadIdentity();
                gluLookAt(0.0, 4.0, 20.0,  
                          0.0, 0.0, 0.0,   
                          0.0, 1.0, 0.0);  

            }

            glRotated(ax--, 1, 0, 0);
            glRotated(ay++, 0, 1, 0);

            //DrawGridLabels();

            DrawGridXZWithLabels();
            DrawAxes();
            glEnable(GL_LIGHTING);
            EnableLighting();
            DrawSphere();
            DrawPartialDisk();

            DrawCylinder();
            glDisable(GL_LIGHTING);

        }

        private void SetMaterial(float[] ambient, float[] diffuse, float[] specular, float shininess)
        {
            glMaterialfv(GL_FRONT_AND_BACK, GL_AMBIENT, ambient);
            glMaterialfv(GL_FRONT_AND_BACK, GL_DIFFUSE, diffuse);
            glMaterialfv(GL_FRONT_AND_BACK, GL_SPECULAR, specular);
            glMaterialf(GL_FRONT_AND_BACK, GL_SHININESS, shininess);
        }


        private void EnableLighting()
        {
            glEnable(GL_LIGHTING);
            glEnable(GL_LIGHT0);

            float[] lightPosition = { 0.0f, 15.0f, 15.0f, 1.0f }; 
            float[] lightAmbient = { 0.3f, 0.3f, 0.3f, 1.0f };    
            float[] lightDiffuse = { 0.8f, 0.8f, 0.8f, 1.0f };    
            float[] lightSpecular = { 1.0f, 1.0f, 1.0f, 1.0f };   

            glLightfv(GL_LIGHT0, GL_POSITION, lightPosition);
            glLightfv(GL_LIGHT0, GL_AMBIENT, lightAmbient);
            glLightfv(GL_LIGHT0, GL_DIFFUSE, lightDiffuse);
            glLightfv(GL_LIGHT0, GL_SPECULAR, lightSpecular);

            glEnable(GL_COLOR_MATERIAL);
            glColorMaterial(GL_FRONT_AND_BACK, GL_AMBIENT_AND_DIFFUSE);

            glEnable(GL_NORMALIZE);
        }

        private void DrawSphere()
        {
            float[] ambient = { 0.2f, 0.2f, 0.6f, 1.0f };  
            float[] diffuse = { 0.5f, 0.5f, 1.0f, 1.0f }; 
            float[] specular = { 1.0f, 1.0f, 1.0f, 1.0f }; 
            float shininess = 50.0f;                     

            SetMaterial(ambient, diffuse, specular, shininess);

            glPushMatrix();

            glTranslated(sphereX, sphereY, sphereZ);

            glColor3d(0.5, 0.5, 1.0); 

            IntPtr quadric = gluNewQuadric();
            if (quadric == IntPtr.Zero)
            {
                throw new Exception("Не вдалося створити Quadric об'єкт.");
            }

            try
            {
                if (isWireframe)
                {
                    gluQuadricDrawStyle(quadric, GLU_LINE);
                }
                else
                {
                    gluQuadricDrawStyle(quadric, GLU_FILL);
                }

                gluQuadricNormals(quadric, GLU_SMOOTH);

                gluSphere(quadric, sphereRadius, segments, segments); 
            }
            finally
            {
                gluDeleteQuadric(quadric);
            }
            glPopMatrix();
        }

        private void DrawPartialDisk()
        {
            float[] ambient = { 0.6f, 0.2f, 0.2f, 1.0f };  
            float[] diffuse = { 0.8f, 0.4f, 0.4f, 1.0f };  
            float[] specular = { 1.0f, 1.0f, 1.0f, 1.0f }; 
            float shininess = 10.0f;                       

            SetMaterial(ambient, diffuse, specular, shininess);

            glPushMatrix();

            glTranslated(-3.5, 3.0, 3.0); 

            glRotated(90, 1, 0, 0); 

            glColor3d(1.0, 0.5, 0.0);

            IntPtr quadric = gluNewQuadric();
            if (quadric == IntPtr.Zero)
            {
                throw new Exception("Не вдалося створити Quadric об'єкт.");
            }

            try
            {
                if (isWireframe)
                {
                    gluQuadricDrawStyle(quadric, GLU_LINE);
                }
                else
                {
                    gluQuadricDrawStyle(quadric, GLU_FILL);
                }

                gluQuadricNormals(quadric, GLU_SMOOTH);

                gluPartialDisk(quadric, diskInnerRadius, diskOuterRadius, segments, 1, diskStartAngle, diskSweepAngle);
            }
            finally
            {
                gluDeleteQuadric(quadric);
            }

            glPopMatrix();
        }



        private void DrawCylinder()
        {
            float[] ambient = { 0.2f, 0.6f, 0.6f, 1.0f };  
            float[] diffuse = { 0.4f, 0.8f, 0.8f, 1.0f };  
            float[] specular = { 1.0f, 1.0f, 1.0f, 1.0f }; 
            float shininess = 25.0f;                       

            SetMaterial(ambient, diffuse, specular, shininess);

            glPushMatrix();
            glTranslated(cylinderX, cylinderY, cylinderZ); 

            glRotated(180, 1, 0, 0);

            glColor3d(0.0, 0.7, 0.7); 

            IntPtr quadric = gluNewQuadric();
            if (quadric == IntPtr.Zero)
            {
                throw new Exception("Не вдалося створити Quadric об'єкт.");
            }

            try
            {
                if (isWireframe)
                {
                    gluQuadricDrawStyle(quadric, GLU_LINE); 
                }
                else
                {
                    gluQuadricDrawStyle(quadric, GLU_FILL); 
                }

                gluQuadricNormals(quadric, GLU_SMOOTH);

                gluCylinder(quadric, cylinderRadius, cylinderRadius, cylinderHeight, segments, segments);
            }
            finally
            {
                gluDeleteQuadric(quadric);
            }

            glPopMatrix();
        }

        private void DrawAxes()
        {
            glBegin(GL_LINES);

            glColor3d(1.0, 0.0, 0.0); 
            glVertex3d(-5.0, 0.0, 0.0); 
            glVertex3d(5.0, 0.0, 0.0);

            glColor3d(0.0, 1.0, 0.0); 
            glVertex3d(0.0, -5.0, 0.0); 
            glVertex3d(0.0, 5.0, 0.0); 

            glColor3d(0.0, 0.0, 1.0); 
            glVertex3d(0.0, 0.0, -5.0); 
            glVertex3d(0.0, 0.0, 5.0);  
            
            glEnd();
            glColor3d(1, 1, 1);
            DrawText("+X", 5, 0.3, 0);
            DrawText("+Y", 0.3, 5, 0);
            DrawText("+Z", 0, 0.3, 5);
            DrawAxisArrows();
        }
       
        private void DrawGridXZWithLabels()
        {
            glColor3d(0.8, 0.8, 0.8); 

            glBegin(GL_LINES);

            for (double x = -4.5; x <= 4.5; x += 0.5)
            {
                glVertex3d(x, 0.0, -4.5); 
                glVertex3d(x, 0.0, 4.5);  
            }

            for (double z = -4.5; z <= 4.5; z += 0.5)
            {
                glVertex3d(-4.5, 0.0, z); 
                glVertex3d(4.5, 0.0, z);  
            }

            glEnd();

            // Додавання міток сітки
            //for (double x = -4.5; x <= 4.5; x += 0.5)
            //{
            //    for (double z = -4.5; z <= 4.5; z += 0.5)
            //    {
            //        if ((x == sphereX && z == sphereZ) || (x == -2.5 && z == -4.5) || (x == -3.5 && z == 3.0))
            //        {
            //            glColor3d(1, 1, 1); 
            //            DrawText($"*({x:F1}, {z:F1})", x, 0.0, z);
            //        }
            //    }
            //}
        }

        private void DrawGridLabels()
        {
            glColor3d(1.0, 1.0, 1.0); 

            DrawText($"*", sphereX, sphereY, sphereZ);

            DrawText($"*", -2.5, -3.5, -4.5);

            DrawText($"*", -3.5, 3.0, 3.0);
            
            for (double i = -4.5; i <= 4.5; i += 0.5)
            {
                if (i != 0) 
                {
                    DrawText($"{i:F1}", i, -0.3, 0.0);

                    DrawText($"{i:F1}", -0.2, i, 0.0); 

                    DrawText($"{i:F1}", 0.0, -0.3, i); 
                }
            }
            DrawText("0", 0.0, -0.2, 0.0);
        }



        private void DrawAxisArrows()
        {
            glBegin(GL_TRIANGLES);
            glColor3d(1.0, 0.0, 0.0); 
            glVertex3d(5.2, 0.0, 0.0); 
            glVertex3d(4.8, 0.2, 0.0); 
            glVertex3d(4.8, -0.2, 0.0); 
            glEnd();

            glBegin(GL_TRIANGLES);
            glColor3d(0.0, 1.0, 0.0); 
            glVertex3d(0.0, 5.2, 0.0); 
            glVertex3d(0.2, 4.8, 0.0); 
            glVertex3d(-0.2, 4.8, 0.0); 
            glEnd();

            glBegin(GL_TRIANGLES);
            glColor3d(0.0, 0.0, 1.0); 
            glVertex3d(0.0, 0.0, 5.2); 
            glVertex3d(0.2, 0.0, 4.8);
            glVertex3d(-0.2, 0.0, 4.8); 
            glEnd();
        }

        bool flag = false;
        Point start;

        private void RenderControl_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            flag = e.Button == System.Windows.Forms.MouseButtons.Left;
            start = e.Location;
        }

        private void RenderControl_MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (flag)
                flag = !(e.Button == System.Windows.Forms.MouseButtons.Left);
        }

        private void RenderControl_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (flag)
            {
                Point current = e.Location;
                ax += (current.Y - start.Y) / 2.0;
                ay += (current.X - start.X) / 2.0;
                start = current;
                Invalidate();
            }
        }
    }
}


