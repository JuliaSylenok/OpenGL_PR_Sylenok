using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace gl_Lab4
{
    public partial class RenderControl : OpenGL
    {
        double size = 1.1;
        double xMin => -size;
        double xMax => size;
        double yMin => -size;
        double yMax => size;

        public int segmentsParabola = 5;
        public int segmentsEllipse = 6;


        private List<PointF> segmentPoints = new List<PointF>(); 
        private List<Shape> shapes = new List<Shape>();
        private LineSegment lineSegment;

        public int SegmentsParabola
        {
            get { return segmentsParabola; }
            set
            {
                segmentsParabola = value;
                UpdateShapes();
                Invalidate();
            }
        }

        public int SegmentsEllipse
        {
            get { return segmentsEllipse; }
            set
            {
                segmentsEllipse = value;
                UpdateShapes();
                Invalidate();
            }
        }

        private void UpdateShapes()
        {
            shapes.Clear();
            shapes.Add(new Ellipse(0.5, 0.3, segmentsEllipse)); 
            shapes.Add(new Parabola(0.5, segmentsParabola));   
        }


        public RenderControl()
        {
            InitializeComponent();
            shapes.Add(new Ellipse(0.5, 0.3, segmentsEllipse)); 
            shapes.Add(new Parabola(0.5, segmentsParabola));    
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else glViewport(0, (Height - Width) / 2, Width, Width);

            glOrtho(xMin, xMax, yMin, yMax, -1.0, 1.0);

            DrawAxes();

            foreach (var shape in shapes)
            {
                shape.Draw();
            }

            lineSegment?.Draw();

            if (lineSegment != null)
            {
                foreach (var shape in shapes)
                {
                    List<PointF> intersections = shape.GetIntersectionPoints(lineSegment);
                    DrawIntersectionPoints(intersections);
                }
            }
        }

        private void DrawAxes()
        {
            glColor3d(0.8, 0.8, 0.8);
            glBegin(GL_LINES);
            glVertex2d(-1.0, 0.0);
            glVertex2d(1.0, 0.0);
            glVertex2d(0.0, -1.0);
            glVertex2d(0.0, 1.0);
            glEnd();

            DrawText("X", +1, -0.1);
            DrawText("Y", +0.02, +1);
            
        }

        private void DrawIntersectionPoints(List<PointF> intersections)
        {
            glColor3d(1.0, 1.0, 0.0); 
            glPointSize(5.0f);
            glBegin(GL_POINTS);
            foreach (var point in intersections)
            {
                glVertex2d(point.X, point.Y);
            }
            glEnd();
            foreach (var point in intersections)
            {
                string text = $"({point.X:F3}; {point.Y:F3})";
                DrawText(text, point.X + 0.02, point.Y + 0.02);
            }
        }

        private void OnMouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            float glX = (float)((e.X / (double)Width) * 2.2 - 1.1);
            float glY = (float)(((Height - e.Y) / (double)Height) * 2.2 - 1.1);

            if (segmentPoints.Count < 2)
            {
                segmentPoints.Add(new PointF(glX, glY));
                if (segmentPoints.Count == 2)
                {
                    lineSegment = new LineSegment(segmentPoints[0], segmentPoints[1]);
                }
            }
            else
            {
                segmentPoints.Clear();
                lineSegment = null;
            }

            Invalidate();
        }
    }
}

