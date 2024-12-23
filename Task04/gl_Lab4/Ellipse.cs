using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab4.OpenGL;
namespace gl_Lab4
{
    public class Ellipse : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        private int Segments { get; set; }

        public Ellipse(double a, double b, int segments)
        {
            A = a;
            B = b;
            Segments = segments;
        }

        public override void Draw()
        {
            glColor3d(0.0, 1.0, 0.0); 
            glBegin(GL_LINE_LOOP);

            double angleStep = 2 * Math.PI / Segments;
            for (int i = 0; i <= Segments; i++)
            {
                double angle = i * angleStep;
                double x = A * Math.Cos(angle);
                double y = B * Math.Sin(angle);
                glVertex2d(x, y);
            }

            glEnd();
        }

        public override List<PointF> GetIntersectionPoints(LineSegment line)
        {
            List<PointF> intersections = new List<PointF>();
            double angleStep = 2 * Math.PI / Segments;
            PointF previousPoint = new PointF((float)(A * Math.Cos(0)), (float)(B * Math.Sin(0)));

            for (int i = 1; i <= Segments; i++)
            {
                double angle = i * angleStep;
                PointF currentPoint = new PointF(
                    (float)(A * Math.Cos(angle)),
                    (float)(B * Math.Sin(angle))
                );

                if (line.CheckIntersection(previousPoint, currentPoint, out PointF intersection))
                {
                    intersections.Add(intersection);
                }

                previousPoint = currentPoint;
            }

            return intersections;
        }
    }
}
