using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab2_3.OpenGL;


namespace gl_Lab2_3
{
    public class TriangleRenderer
    {
        private bool fill;
        private bool line;
        private bool points;

        public TriangleRenderer(bool fill, bool line, bool points)
        {
            this.fill = fill;
            this.line = line;
            this.points = points;
        }

        public void DrawTriangle(double[,] vertices, int v1, int v2, double offsetX, double offsetY, float r, float g, float b)
        {
            if (fill)
            {
                glColor3f(r, g, b);
                glBegin(GL_TRIANGLE_FAN);
                glVertex2d(offsetX, offsetY);
                glVertex2d(vertices[v1, 0], vertices[v1, 1]);
                glVertex2d(vertices[v2, 0], vertices[v2, 1]);
                glEnd();
            }
            if (line)
            {
                glColor3f(r, g, b);
                glBegin(GL_LINE_LOOP);
                glVertex2d(offsetX, offsetY);
                glVertex2d(vertices[v1, 0], vertices[v1, 1]);
                glVertex2d(vertices[v2, 0], vertices[v2, 1]);
                glEnd();
            }
            if (points)
            {
                glPointSize(5.0f);
                glColor3f(r, g, b);
                glBegin(GL_POINTS);
                glVertex2d(offsetX, offsetY);
                glVertex2d(vertices[v1, 0], vertices[v1, 1]);
                glVertex2d(vertices[v2, 0], vertices[v2, 1]);
                glEnd();
            }
        }
    }


}
