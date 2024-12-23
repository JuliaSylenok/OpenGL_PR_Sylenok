using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab4.OpenGL;



namespace gl_Lab4
{
    public class Parabola : Shape
    {
        public double A { get; set; }
        private int Points { get; set; }

        public Parabola(double a, int points)
        {
            A = a;
            Points = points;
        }

        public override void Draw()
        {
            glColor3d(0.0, 0.0, 1.0);
            glBegin(GL_LINE_STRIP);

            double step = 2.0 / Points;
            for (double x = -1.0; x <= 1.0; x += step)
            {
                double y = A * x * x;
                glVertex2d(x, y);
            }

            glEnd();
        }
        public override List<PointF> GetIntersectionPoints(LineSegment line)
        {
            return new List<PointF>();
        }
    }

}
