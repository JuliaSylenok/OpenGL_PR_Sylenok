using System.Windows.Forms;
using static gl_Lab4.OpenGL;


namespace gl_Lab4
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();

        }

        private void numeric_Parabola_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SegmentsParabola = (int)numeric_Parabola.Value;
            renderControl1.Invalidate();
        }

        private void numeric_Elips_ValueChanged(object sender, System.EventArgs e)
        {
            renderControl1.SegmentsEllipse = (int)numeric_Elips.Value;
            renderControl1.Invalidate();
        }
    }
}
