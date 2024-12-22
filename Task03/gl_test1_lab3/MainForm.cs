using System;
using System.Windows.Forms;
using static gl_test1_lab3.OpenGL;


namespace gl_test1_lab3
{
    public partial class MainForm : Form
    {
        private RenderParameters parameters;

        public MainForm()
        {
            InitializeComponent();
            parameters = new RenderParameters();
            renderControl1.Parameters = parameters; 

        }

        private void numericUpDown_Xmin_ValueChanged(object sender, EventArgs e)
        {
            parameters.Xmin = (double)numericUpDown_Xmin.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDown_Xmax_ValueChanged(object sender, EventArgs e)
        {
            parameters.Xmax = (double)numericUpDown_Xmax.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDown_Ymin_ValueChanged(object sender, EventArgs e)
        {
            parameters.Ymin = (double)numericUpDown_Ymin.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDown_Ymax_ValueChanged(object sender, EventArgs e)
        {
            parameters.Ymax = (double)numericUpDown_Ymax.Value;
            renderControl1.Invalidate();
        }

        private void numericUpDown_N_ValueChanged(object sender, EventArgs e)
        {
            parameters.N = (int)numericUpDown_N.Value;
            renderControl1.Invalidate();
        }


        private void checkBox_F2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_F2.Checked)
            {
                numericUpDown_Ymin.Value = (decimal)parameters.Ymin;
                numericUpDown_Ymax.Value = (decimal)parameters.Ymax;
                label_Ymax.Visible = true;
                label_Ymin.Visible = true;
                numericUpDown_Ymax.Visible = true;
                numericUpDown_Ymin.Visible = true;

                parameters.UseFunction2(
                    () => (double)numericUpDown_Ymin.Value,
                    () => (double)numericUpDown_Ymax.Value
                );
            }
            else
            {
                parameters.UseFunction1();

                label_Ymax.Visible = false;
                label_Ymin.Visible = false;
                numericUpDown_Ymax.Visible = false;
                numericUpDown_Ymin.Visible = false;
            }

            renderControl1.Invalidate();
        }

    }
}
