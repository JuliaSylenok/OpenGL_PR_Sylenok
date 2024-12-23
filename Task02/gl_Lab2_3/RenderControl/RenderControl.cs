using gl_Lab_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;

namespace gl_Lab2_3
{
    public partial class RenderControl : OpenGL
    {
        private RenderSettings settings;
        public RenderControl()
        {
            InitializeComponent();
        }

        public void SetSettings(RenderSettings renderSettings)
        {
            settings = renderSettings;
        }
        
        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            float aspectRatio = (float)Width / Height;

            int horizont = settings.Horizont;
            int vertical = settings.Vertical;

            if (Width > Height)
                glViewport((Width - Height) / 2, 0, Height, Height);
            else glViewport(0, (Height - Width) / 2, Width, Width);
            if (vertical > horizont)
                gluOrtho2D(-0.3 * (vertical), +0.3 * (vertical), -0.3 * (vertical / 1), 0);
            else if (vertical == 1 && horizont == 1)
                gluOrtho2D(-0.3, +0.3, -0.3, +0.3);
            else gluOrtho2D(-0.3 * (horizont / 2), +0.3 * (horizont), -0.3 * (horizont / 1), +0.3);

            for (int v = 0; v < vertical; v++)
            {
                for (int h = 0; h < horizont; h++)
                {
                    double offsetX = 0.23 * h;  
                    double offsetY = -0.1299 * (h % 2) - 0.2598 * v; 
                    DrawHexagonAndTriangles(offsetX, offsetY);
                }
            }
        }

        private void DrawHexagonAndTriangles(double offsetX, double offsetY)
        {
            HexagonRenderer hexagonRenderer = new HexagonRenderer(0.15, settings.Fill, settings.Line, settings.Points);
            hexagonRenderer.DrawHexagon(offsetX, offsetY);
        }

    }

}

