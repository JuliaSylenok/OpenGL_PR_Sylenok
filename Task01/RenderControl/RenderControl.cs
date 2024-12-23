using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;


namespace gl_Lab1
{
    public partial class RenderControl : OpenGL
    {
        Figure figure = new Figure();

        public RenderControl()
        {
            InitializeComponent();
        }

        private void RenderControl_Render(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);

            gluOrtho2D(-3.5, 9.8, -2.5, 5.5);

            figure.DrawGrid();
            figure.DrawAxes();
            figure.DrawPentagon();
            figure.DrawPoints();
            
            glColor3f(0, 0, 0);
            DrawText("X", 8.7, -1.8); 
            DrawText("Y", -2.7, 4.7); 
            DrawText("0", -2.5, -1.8);
            
        }
    }
}
