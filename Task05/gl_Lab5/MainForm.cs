using System.Windows.Forms;
using static gl_Lab5.OpenGL;


namespace gl_Lab5
{
    public partial class MainForm : Form
    {
        private RenderSettings renderSettings = new RenderSettings();
        public MainForm()
        {
            InitializeComponent();

            radioButton_Fill.Checked =true;
            radioButton_Line.Checked = false;
        }

        private void radioButton_Fill_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_Fill.Checked)
            {
                renderControl1.IsWireframe = false; 
            }
        }

        private void radioButton_Line_CheckedChanged(object sender, System.EventArgs e)
        {
            if (radioButton_Line.Checked)
            {
                renderControl1.IsWireframe = true; 
            }
        }

        private void checkBox_Ortho_or_Perspective_CheckedChanged(object sender, System.EventArgs e)
        {
            renderControl1.OrthoPerspective = checkBox_Ortho_or_Perspective.Checked; 
        }

    }
}
