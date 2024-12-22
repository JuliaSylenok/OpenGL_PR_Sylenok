using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab4.OpenGL;


namespace gl_Lab4
{
    public class LineSegment
    {
        public PointF Start { get; set; }
        public PointF End { get; set; }

        public LineSegment(PointF start, PointF end)
        {
            Start = start;
            End = end;
        }
        public void Draw()
        {
            glColor3d(1.0, 0.0, 0.0); 
            glBegin(GL_LINES);
            glVertex2d(Start.X, Start.Y);
            glVertex2d(End.X, End.Y);
            glEnd();
        }

        public bool CheckIntersection(PointF p1, PointF p2, out PointF intersection)
        {
            intersection = default;

            double a11 = End.X - Start.X;
            double a12 = p1.X - p2.X;
            double a21 = End.Y - Start.Y;
            double a22 = p1.Y - p2.Y;
            double b1 = p1.X - Start.X;
            double b2 = p1.Y - Start.Y;

            double det = a11 * a22 - a12 * a21;

            if (Math.Abs(det) < 1e-6)
                return false;

            double det1 = b1 * a22 - a12 * b2;
            double det2 = a11 * b2 - b1 * a21;

            double t1 = det1 / det;
            double t2 = det2 / det;

            if (t1 < 0 || t1 > 1 || t2 < 0 || t2 > 1)
                return false;

            intersection = new PointF(
                (float)(Start.X + t1 * (End.X - Start.X)),
                (float)(Start.Y + t1 * (End.Y - Start.Y))
            );

            return true;
        }
    }
}
