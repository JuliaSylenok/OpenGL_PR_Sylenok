using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Task06.OpenGL;


namespace gl_Task06
{
    public class Segment
    {
        public double Size { get; set; }
        public int LineWidth { get; set; }

        public Segment(double size, int lineWidth)
        {
            Size = size;
            LineWidth = lineWidth;
        }

        public void Draw()
        {
            
            glLineWidth(LineWidth);
            glBegin(GL_LINE_STRIP);
            glVertex3d(0.0, 0.0, Size * 0.1);
            glVertex3d(0.0, Size, Size * 0.1);
            glVertex3d(0.0, Size, -Size * 0.1);
            glVertex3d(0.0, 0.0, -Size * 0.1);
            glVertex3d(0.0, 0.0, Size * 0.1);
            glEnd();
            glLineWidth(1);
        }
    }

}
