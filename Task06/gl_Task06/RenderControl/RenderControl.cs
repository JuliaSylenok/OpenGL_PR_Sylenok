using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Windows.Forms;

namespace gl_Task06
{
    public partial class RenderControl : OpenGL
    {
        public event Action UpdateInfo;

        private double ax = +20;
        private double ay = -30;
        private double m = 1;
        private double aw = 0;

        private bool fDown = false;
        private double x0, y0;
        public double a { get { return 1.3; } }
        public double a1 { get { return 0.31 * a; } }
        public double c { get { return 0.55; } }

        private bool MoveAxes = true;
        private int dx;
        private int dy;

        private double az;
        private double s = 0.2;
        private double sb = 0.2;

        public double S
        {
            get { return s; }
            set
            {
                if (value <= (a1 + c) && value >= (c - a1))
                    s = value;
            }
        }

        public double Sb
        {
            get { return sb; }
            set
            {
                if (value <= (a1 + c) && value >= (c - a1))
                    sb = value;
            }
        }

        private double ag
        {
            get
            {
                return 180.0 / Math.PI * (Math.PI - Math.Acos((a1 * a1 + S * S - c * c) / (2 * a1 * S)));
            }
        }
        private double agb
        {
            get
            {
                return 180.0 / Math.PI * (Math.PI - Math.Acos((a1 * a1 + Sb * Sb - c * c) / (2 * a1 * Sb)));
            }
        }
        private double az_m;
        public double a_m { get { return -0.68; } }
        public double a1_m { get { return -0.34; } }
        public double b_m { get { return -0.9; } }
        public double c_m { get { return -0.68; } }

        public double dist { get; set; }

        public bool gridX { get; set; }
        public bool gridY { get; set; }
        public bool gridZ { get; set; }
        public bool Perspectiv;

        private double size = 2.5;
        private double AspectRatio => (double)Width / Height;
        private double xMin => (AspectRatio > 1) ? -size * AspectRatio : -size;
        private double xMax => (AspectRatio > 1) ? +size * AspectRatio : +size;
        private double yMin => (AspectRatio < 1) ? -size / AspectRatio : -size;
        private double yMax => (AspectRatio < 1) ? +size / AspectRatio : +size;
        private double zMin => -size * 2.0;
        private double zMax => +size * 2.0;
        private Segment redSegment;
        private Segment greenSegment;
        private Segment blueSegment;
        public RenderControl()
        {
            InitializeComponent();
            MouseWheel += OnMouseWheel;
            redSegment = new Segment(a_m, 5);
            greenSegment = new Segment(c_m, 5);
            blueSegment = new Segment(b_m, 5);

        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fDown = true;
                x0 = e.Location.X;
                y0 = e.Location.Y;
            }
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            if (fDown && e.Button == MouseButtons.Left)
                fDown = false;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            if (fDown)
            {
                ay -= (x0 - e.X) / 2.0;
                ax -= (y0 - e.Y) / 2.0;
                x0 = e.X;
                y0 = e.Y;
                Invalidate();
            }
        }

        private void OnMouseWheel(object sender, MouseEventArgs e)
        {
            m += e.Delta / 1000.0;
            Invalidate();
        }

        private void RenderControl_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left: az -= 1; break;
                case Keys.Right: az += 1; break;
                case Keys.Up: S += 0.01; break;
                case Keys.Down: S -= 0.01; break;
                case Keys.W: Sb += 0.01; break;
                case Keys.S: Sb -= 0.01; break;
                case Keys.Q: aw += 1; break;
                case Keys.E: aw -= 1; break;

            }
            Invalidate();
        }

        private void OnRender(object sender, EventArgs e)
        {
            glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);

            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();

            if (Perspectiv)
                gluPerspective(45, AspectRatio, 0.1, 1000.0);
            else
                glOrtho(xMin, xMax, yMin, yMax, zMin, zMax);

            glMatrixMode(GL_MODELVIEW);
            glLoadIdentity();
            glViewport(0, 0, Width, Height);

            if (Perspectiv)
                glTranslated(0, 0, -size);

            glRotated(ax, 1, 0, 0);
            glRotated(ay, 0, 1, 0);
            glScaled(m, m, m);

            glEnable(GL_LIGHTING);
            glEnable(GL_COLOR_MATERIAL);
            glEnable(GL_DEPTH_TEST);
            glEnable(GL_LIGHT0);

            glColor(Color.Black);
            Axes(1.9);

            dist = S;
            glRotated(aw, 0, -1, 0);
            glRotated(az, 0, 0, -1);

            glPushMatrix();
            glColor(Color.Red);
            redSegment.Draw();

            glTranslated(0, a_m, 0);
            glRotated(agb, 0, 0, -1);
            glColor(Color.Green);
            greenSegment.Draw();

            glPopMatrix();
            glPushMatrix();

            glTranslated(0, a1_m, 0);
            glRotated(ag, 0, 0, 1);
            glColor(Color.Blue);
            blueSegment.Draw();

            glPopMatrix();

            glDisable(GL_LIGHTING);
            glDisable(GL_COLOR_MATERIAL);
            glDisable(GL_DEPTH_TEST);

            UpdateInfo?.Invoke();
        }

        private void Axes(double size)
        {
            double a = size / 15.0;
            glBegin(GL_LINES);
            glVertex3d(-a, 0, 0); glVertex3d(+size, 0, 0);
            glVertex3d(0, a, 0); glVertex3d(0, -size, 0);
            glVertex3d(0, 0, -a); glVertex3d(0, 0, +size);
            glEnd();
            DrawText("+X", size + a, 0, 0);
            DrawText("-Y", 0, -size + a, 0);
            DrawText("+Z", 0, 0, size + a);

            Grid(gridX, gridY, gridZ, size, -size * 0.1, 5);
        }

        private void Grid(bool x, bool y, bool z, double s, double shift, int count = 10)
        {
            double h = s / count;
            glColor(Color.AliceBlue);
            glEnable(GL_LINE_STIPPLE);
            glLineStipple(1, 0xCCCC);
            glBegin(GL_LINES);
            for (int i = 0; i <= count; i++)
            {
                if (z) { glVertex3d(i * h, 0, shift); glVertex3d(i * h, s, shift); }
                if (y) { glVertex3d(i, shift, i * h); glVertex3d(s, shift, i * h); }
                if (x) { glVertex3d(shift, 0, i * h); glVertex3d(shift, s, i * h); }
            }
            glEnd();
            glDisable(GL_LINE_STIPPLE);
        }
    }
}

