using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab4.OpenGL;

namespace gl_Lab4
{
    public abstract class Shape
    {
        public abstract void Draw();
        public abstract List<PointF> GetIntersectionPoints(LineSegment line);
    }
}
