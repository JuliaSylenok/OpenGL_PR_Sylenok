using gl_Lab2_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static gl_Lab2_3.OpenGL;

namespace gl_Lab_2
{
    public class HexagonRenderer
    {
        private double radius;
        private bool fill;
        private bool line;
        private bool points;

        public HexagonRenderer(double radius, bool fill, bool line, bool points)
        {
            this.radius = radius;
            this.fill = fill;
            this.line = line;
            this.points = points;
        }

        public void DrawHexagon(double offsetX, double offsetY)
        {
            int numVertices = 6;
            double[,] vertices = new double[numVertices, 2];

            for (int i = 0; i < numVertices; i++)
            {
                double angle = 2.0 * Math.PI * i / numVertices;
                double x = radius * Math.Cos(angle) + offsetX;
                double y = radius * Math.Sin(angle) + offsetY;
                vertices[i, 0] = x;
                vertices[i, 1] = y;
            }

            if (fill)
            {
                glColor3f(1.0f, 0.0f, 0.0f);
                glBegin(GL_POLYGON);
                for (int i = 0; i < numVertices; i++)
                {
                    glVertex2d(vertices[i, 0], vertices[i, 1]);
                }
                glEnd();
            }
            if (line)
            {
                glColor3f(1.0f, 0.0f, 0.0f);
                glBegin(GL_LINE_LOOP);
                for (int i = 0; i < numVertices; i++)
                {
                    glVertex2d(vertices[i, 0], vertices[i, 1]);
                }
                glEnd();
            }
            if (points)
            {
                glPointSize(5.0f);
                glColor3f(1.0f, 0.0f, 0.0f);
                glBegin(GL_POINTS);
                for (int i = 0; i < numVertices; i++)
                {
                    glVertex2d(vertices[i, 0], vertices[i, 1]);
                }
                glEnd();
            }

            TriangleRenderer triangleRenderer = new TriangleRenderer(fill, line, points);
            triangleRenderer.DrawTriangle(vertices, 0, 1, offsetX, offsetY, 1, 1, 0);
            triangleRenderer.DrawTriangle(vertices, 0, 5, offsetX, offsetY, 0, 1, 1);
            triangleRenderer.DrawTriangle(vertices, 4, 5, offsetX, offsetY, 0, 1, 0);
        }
    }


}
