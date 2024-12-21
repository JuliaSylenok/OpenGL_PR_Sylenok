using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab1.OpenGL;


namespace gl_Lab1
{
    internal class Figure
    {
        public void DrawPentagon()
        {
            glColor3d(0, 1, 1);
           
            glLineWidth(2.5f); 
            glBegin(GL_LINES);

            glVertex2d(-1.5, 1.5);
            glVertex2d(0.5, 3.5);

            glVertex2d(0.5, 3.5);
            glVertex2d(1.5, 2.5);

            glVertex2d(1.5, 2.5);
            glVertex2d(1.5, -0.5);

            glVertex2d(1.5, -0.5);
            glVertex2d(-0.5, 0.5);

            glVertex2d(-0.5, 0.5);
            glVertex2d(-1.5, 1.5);

            glEnd();
        }

        public void DrawPoints()
        {
            glPointSize(8.0f); 
            
            glBegin(GL_POINTS);

            glVertex2d(3.5, 1.5);
            glVertex2d(4.5, 0.5);
            glVertex2d(5.5, 3.5);
            glVertex2d(6.5, 2.5);
            glVertex2d(6.5, -0.5);

            glEnd();
        }

        public void DrawAxes()
        {
            glColor3f(0.0f, 0.0f, 0.0f);

            glLineWidth(3.0f);
            glBegin(GL_LINES);

            glVertex2d(-2.5, -1.5);
            glVertex2d(8.5, -1.5);

            glVertex2d(8.3, -1.3);
            glVertex2d(8.5, -1.5);

            glVertex2d(8.3, -1.7);
            glVertex2d(8.5, -1.5);

            glVertex2d(-2.5, -1.5);
            glVertex2d(-2.5, 4.5);

            glVertex2d(-2.3, 4.3);
            glVertex2d(-2.5, 4.5);

            glVertex2d(-2.7, 4.3);
            glVertex2d(-2.5, 4.5);

            glEnd();
        }

        public void DrawGrid()
        {
            glLineStipple(1, 0xAAAA);
            glEnable(GL_LINE_STIPPLE);

            glLineWidth(1.0f);
            glBegin(GL_LINES);

            for (double x = -3.5; x <= 9.8; x += 1.0)
            {
                glVertex2d(x, -2.5);
                glVertex2d(x, 5.5);
                
            }

            for (double y = -2.5; y <= 5.5; y += 1.0)
            {
                glVertex2d(-3.5, y);
                glVertex2d(9.8, y);
            }

            glEnd();
            glDisable(GL_LINE_STIPPLE);
            
        }
    }
}
