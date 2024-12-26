using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;

namespace glScrSaver1
{
    public partial class RenderControl : OpenGL
    {

        private double x = 0.1, y = 0.0, z = 0.0;
        private double dt = 0.01;
        private const double sigma = 10.0;
        private const double rho = 28.0;
        private const double beta = 8.0 / 3.0;

        private double rotationX = 0.0; 
        private double rotationY = 0.0; 
        private double rotationSpeedX; // Швидкість повороту по X 
        private double rotationSpeedY = 0.3; // Фіксована швидкість повороту по Y

        private double offsetX = 0.0; 
        private double offsetY = 0.0; 
        private double offsetZ = -30.0; // Зсув по Z (переміщення назад)
        private double scaleFactor; // Масштабування системи 
        private double scaleSpeed = 0.01; // Швидкість зміни масштабу
        private bool scalingUp = true;   // Напрямок зміни масштабу


        private List<(double x, double y, double z)> trajectory = new List<(double x, double y, double z)>();

        public RenderControl()
        {
            InitializeComponent();
        }

        private void OnContextCreated(object sender, EventArgs e)
        {
            glClearColor(Color.Black);

            try
            {
                rotationSpeedX = AppSettings.RotationSpeedX;
                scaleFactor = AppSettings.ScaleFactor;
                Debug.WriteLine("Settings applied to RenderControl.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading settings in RenderControl: {ex.Message}");
            }
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
            glLoadIdentity();

            glViewport(0, 0, Width, Height);
            glOrtho(-10, 10, -10, 10, -1, 1);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            gluPerspective(45.0, (double)Width / Height, 1.0, 120.0);
            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();

            gluLookAt(0.0, 0.0, 100.0, offsetX, offsetY, offsetZ, 0.0, 1.0, 0.0);

            glRotated(rotationX, 1.0, 0.0, 0.0);
            glRotated(rotationY, 0.0, 1.0, 0.0);

            DrawLorenz();

            UpdateLorenz();
            rotationX += rotationSpeedX;

            glFlush();
        }

        private void DrawLorenz()
        {
            glBegin(GL_LINE_STRIP);

            foreach (var (px, py, pz) in trajectory)
            {
                glColor3d((px + 20) / 40.0, (py + 30) / 60.0, (pz + 50) / 100.0);
                glVertex3d((px * scaleFactor) + offsetX, (py * scaleFactor) + offsetY, (pz * scaleFactor) + offsetZ);
            }

            glEnd();
        }

        private void UpdateLorenz()
        {
            double dx = sigma * (y - x) * dt;
            double dy = (x * (rho - z) - y) * dt;
            double dz = (x * y - beta * z) * dt;

            x += dx;
            y += dy;
            z += dz;

            trajectory.Add((x, y, z));

            if (trajectory.Count > 3000)
            {
                trajectory.RemoveAt(0);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            rotationX += rotationSpeedX;
            rotationY += rotationSpeedY;

            if (rotationX >= 360.0) rotationX -= 360.0;
            if (rotationY >= 360.0) rotationY -= 360.0;

            if (scalingUp)
            {
                scaleFactor += scaleSpeed;
                if (scaleFactor >= 3.0) 
                {
                    scalingUp = false;
                }
            }
            else
            {
                scaleFactor -= scaleSpeed;
                if (scaleFactor <= 0.2)
                {
                    scalingUp = true;
                }
            }

            Invalidate();
        }
    }
}

