using gl_test1_lab3;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace gl_test1_lab3
{
    public partial class RenderControl : OpenGL
    {
        public RenderParameters Parameters { get; set; } = new RenderParameters();

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnRender(object sender, EventArgs e)
        {
            double calculatedYmin;
            double calculatedYmax;

            Parameters.CurrentRenderer.CalculateYBounds(
                Parameters.Xmin,
                Parameters.Xmax,
                Parameters.N,
                out calculatedYmin,
                out calculatedYmax
            );

            Parameters.Ymin = calculatedYmin;
            Parameters.Ymax = calculatedYmax;

            glClear(GL_COLOR_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            gluOrtho2D(Parameters.Xmin-0.15, Parameters.Xmax+0.15, Parameters.Ymin-0.15, Parameters.Ymax+0.15);

            DrawAxesAndGrid();
            DrawAxisLabels();
            DrawTicks();
            DrawGraph();
            DrawIntersections();
            
        }

        private void DrawGraph()
        {
            double step = (Parameters.Xmax - Parameters.Xmin) / Parameters.N;
            bool isContinuous = true;

            for (double x = Parameters.Xmin; x < Parameters.Xmax; x += step)
            {
                double y1 = Parameters.CurrentRenderer.CalculateFunction(x);
                double y2 = Parameters.CurrentRenderer.CalculateFunction(x + step);

                if (double.IsInfinity(y1) || double.IsInfinity(y2) || Math.Abs(y2 - y1) > 10 || !IsDefined(x) || !IsDefined(x + step))
                {
                    isContinuous = false;
                }
                else
                {
                    if (isContinuous)
                    {
                        glColor3f(0.0f, 1.0f, 0.0f); 
                        glBegin(GL_LINES);
                        glVertex2d(x, y1);
                        glVertex2d(x + step, y2);
                        glEnd();
                    }
                    else
                    {
                        glLineStipple(1, 0xAAAA); 
                        glEnable(GL_LINE_STIPPLE);
                        glColor3f(1.0f, 0.0f, 0.0f); 

                        glBegin(GL_LINES);
                        glVertex2d(x, y1);
                        glVertex2d(x + step, y2);
                        glEnd();

                        glDisable(GL_LINE_STIPPLE); 
                    }
                    isContinuous = true;
                }
            }
        }

        private bool IsDefined(double x)
        {
            double cosValue = Math.Cos(Math.PI * x);
            return Math.Abs(cosValue) > 1e-10; 
        }

        private void DrawIntersections()
        {
            glPointSize(5);
            glColor3f(1.0f, 0.0f, 0.0f); 

            double step = (Parameters.Xmax - Parameters.Xmin) / Parameters.N;

            for (double x = Parameters.Xmin; x <= Parameters.Xmax - step; x += step)
            {
                double y1 = Parameters.CurrentRenderer.CalculateFunction(x);
                double y2 = Parameters.CurrentRenderer.CalculateFunction(x + step);

                if (y1 * y2 <= 0 && IsDefined(x) && IsDefined(x + step))
                {
                    double x0 = BisectionMethod(x, x + step);
                    double y0 = Parameters.CurrentRenderer.CalculateFunction(x0);

                    glBegin(GL_POINTS);
                    glVertex2d(x0, 0);
                    glEnd();
                }
            }
        }

        private double BisectionMethod(double xLeft, double xRight)
        {
            double tolerance = 1e-5; 
            double midPoint;

            while ((xRight - xLeft) > tolerance)
            {
                midPoint = (xLeft + xRight) / 2.0;
                double yMid = Parameters.CurrentRenderer.CalculateFunction(midPoint);
                double yLeft = Parameters.CurrentRenderer.CalculateFunction(xLeft);

                if (yMid == 0) 
                {
                    return midPoint;
                }
                else if (yLeft * yMid < 0)
                {
                    xRight = midPoint; 
                }
                else
                {
                    xLeft = midPoint; 
                }
            }

            return (xLeft + xRight) / 2.0; 
        }


        private void DrawAxesAndGrid()
        {
            glLineStipple(1, 0xAAAA); 
            glEnable(GL_LINE_STIPPLE);

            glBegin(GL_LINES);
            glColor3f(0.8f, 0.8f, 0.8f); 
            for (double x = Parameters.Xmin; x <= Parameters.Xmax; x += 1.0)
            {
                glVertex2d(x, Parameters.Ymin);
                glVertex2d(x, Parameters.Ymax);
            }

            for (double y = Parameters.Ymin; y <= Parameters.Ymax; y += 1.0)
            {
                glVertex2d(Parameters.Xmin, y);
                glVertex2d(Parameters.Xmax, y);
            }
            glEnd();

            glDisable(GL_LINE_STIPPLE);

            glLineWidth(2.0f);
            glColor3f(1.0f, 1.0f, 1.0f); 
            glBegin(GL_LINES);

            glVertex2d(Parameters.Xmin, 0);
            glVertex2d(Parameters.Xmax, 0);

            glVertex2d(0, Parameters.Ymin);
            glVertex2d(0, Parameters.Ymax);

            glEnd();
        }

        private void DrawAxisLabels()
        {
            glColor3f(1.0f, 1.0f, 1.0f); 

            for (double x = Math.Ceiling(Parameters.Xmin); x <= Parameters.Xmax; x += 1.0)
            {
                DrawText($"{x}", x + 0.05, -0.3);
            }

            for (double y = Math.Ceiling(Parameters.Ymin); y <= Parameters.Ymax; y += 1.0)
            {
                if (Math.Abs(y) > 0.1)
                {
                    DrawText($"{y}", -0.2, y);
                }
            }
        }

        private void DrawTicks()
        {
            glColor3f(1.0f, 1.0f, 1.0f); 
            glBegin(GL_LINES);

            for (double x = Math.Ceiling(Parameters.Xmin); x <= Parameters.Xmax; x += 1.0)
            {
                glLineWidth(2.0f);
                glVertex2d(x, -0.1); 
                glVertex2d(x, 0.1);  
            }

            for (double y = Math.Ceiling(Parameters.Ymin); y <= Parameters.Ymax; y += 1.0)
            {
                if (Math.Abs(y) > 0.1) 
                {
                    glLineWidth(2.0f);
                    glVertex2d(-0.1, y); 
                    glVertex2d(0.1, y);  
                }
            }

            glEnd();
        }

        
    }

}
