using System;
using System.Windows.Forms;
using static gl_Lab2_3.OpenGL;


namespace gl_Lab2_3
{
    public partial class MainForm : Form
    {
        private RenderSettings renderSettings;
        public MainForm()
        {
            InitializeComponent();
            renderSettings = new RenderSettings
            {
                Horizont = 1,
                Vertical = 1,
                Fill = true,
                Line = false,
                Points = false
            };
            
            numericUpDown_Horizont.Value = renderSettings.Horizont;
            numericUpDown_Vertical.Value = renderSettings.Vertical;
            radioButton_Fill.Checked = renderSettings.Fill;

            renderControl1.SetSettings(renderSettings);

        }

        private void numericUpDown_Horizont_ValueChanged(object sender, EventArgs e)
        {
            renderSettings.Horizont = (int)numericUpDown_Horizont.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDown_Vertical_ValueChanged(object sender, EventArgs e)
        {
            renderSettings.Vertical = (int)numericUpDown_Vertical.Value;
            renderControl1.Invalidate();
        }

        private void radioButton_Fill_CheckedChanged(object sender, EventArgs e)
        {
            renderSettings.Fill = radioButton_Fill.Checked;
            renderControl1.Invalidate();
        }

        private void radioButton_Line_CheckedChanged(object sender, EventArgs e)
        {
            renderSettings.Line = radioButton_Line.Checked;
            renderControl1.Invalidate();
        }

        private void radioButton_Points_CheckedChanged(object sender, EventArgs e)
        {
            renderSettings.Points = radioButton_Points.Checked;
            renderControl1.Invalidate();
        }
    }
}
