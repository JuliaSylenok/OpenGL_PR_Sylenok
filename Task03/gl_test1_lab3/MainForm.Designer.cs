
namespace gl_test1_lab3
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RenderParameters renderParameters1 = new RenderParameters();
            Function1Renderer function1Renderer1 = new Function1Renderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            renderControl1 = new RenderControl();
            label_Xmin = new System.Windows.Forms.Label();
            label_Xmax = new System.Windows.Forms.Label();
            label_Ymin = new System.Windows.Forms.Label();
            label_Ymax = new System.Windows.Forms.Label();
            numericUpDown_Xmin = new System.Windows.Forms.NumericUpDown();
            numericUpDown_Xmax = new System.Windows.Forms.NumericUpDown();
            numericUpDown_Ymin = new System.Windows.Forms.NumericUpDown();
            numericUpDown_Ymax = new System.Windows.Forms.NumericUpDown();
            numericUpDown_N = new System.Windows.Forms.NumericUpDown();
            label_Points = new System.Windows.Forms.Label();
            checkBox_F2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Xmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Xmax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Ymin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Ymax).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_N).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 29);
            renderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            renderControl1.Name = "renderControl1";
            renderParameters1.CurrentRenderer = function1Renderer1;
            renderParameters1.N = 2000;
            renderParameters1.Xmax = 4D;
            renderParameters1.Xmin = -2D;
            renderParameters1.Ymax = 4D;
            renderParameters1.Ymin = -4D;
            renderControl1.Parameters = renderParameters1;
            renderControl1.Size = new System.Drawing.Size(600, 375);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // label_Xmin
            // 
            label_Xmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_Xmin.AutoSize = true;
            label_Xmin.Location = new System.Drawing.Point(640, 70);
            label_Xmin.Name = "label_Xmin";
            label_Xmin.Size = new System.Drawing.Size(61, 20);
            label_Xmin.TabIndex = 6;
            label_Xmin.Text = "Xmin = ";
            // 
            // label_Xmax
            // 
            label_Xmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_Xmax.AutoSize = true;
            label_Xmax.Location = new System.Drawing.Point(637, 103);
            label_Xmax.Name = "label_Xmax";
            label_Xmax.Size = new System.Drawing.Size(64, 20);
            label_Xmax.TabIndex = 7;
            label_Xmax.Text = "Xmax = ";
            // 
            // label_Ymin
            // 
            label_Ymin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_Ymin.AutoSize = true;
            label_Ymin.Location = new System.Drawing.Point(642, 136);
            label_Ymin.Name = "label_Ymin";
            label_Ymin.Size = new System.Drawing.Size(59, 20);
            label_Ymin.TabIndex = 8;
            label_Ymin.Text = "Ymin = ";
            label_Ymin.Visible = false;
            // 
            // label_Ymax
            // 
            label_Ymax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_Ymax.AutoSize = true;
            label_Ymax.Location = new System.Drawing.Point(640, 169);
            label_Ymax.Name = "label_Ymax";
            label_Ymax.Size = new System.Drawing.Size(58, 20);
            label_Ymax.TabIndex = 9;
            label_Ymax.Text = "Ymax =";
            label_Ymax.Visible = false;
            // 
            // numericUpDown_Xmin
            // 
            numericUpDown_Xmin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Xmin.Location = new System.Drawing.Point(709, 68);
            numericUpDown_Xmin.Maximum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDown_Xmin.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown_Xmin.Name = "numericUpDown_Xmin";
            numericUpDown_Xmin.Size = new System.Drawing.Size(93, 27);
            numericUpDown_Xmin.TabIndex = 10;
            numericUpDown_Xmin.Value = new decimal(new int[] { 2, 0, 0, int.MinValue });
            numericUpDown_Xmin.ValueChanged += numericUpDown_Xmin_ValueChanged;
            // 
            // numericUpDown_Xmax
            // 
            numericUpDown_Xmax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Xmax.Location = new System.Drawing.Point(709, 101);
            numericUpDown_Xmax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Xmax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Xmax.Name = "numericUpDown_Xmax";
            numericUpDown_Xmax.Size = new System.Drawing.Size(93, 27);
            numericUpDown_Xmax.TabIndex = 11;
            numericUpDown_Xmax.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown_Xmax.ValueChanged += numericUpDown_Xmax_ValueChanged;
            // 
            // numericUpDown_Ymin
            // 
            numericUpDown_Ymin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Ymin.Location = new System.Drawing.Point(709, 134);
            numericUpDown_Ymin.Maximum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numericUpDown_Ymin.Minimum = new decimal(new int[] { 10, 0, 0, int.MinValue });
            numericUpDown_Ymin.Name = "numericUpDown_Ymin";
            numericUpDown_Ymin.Size = new System.Drawing.Size(93, 27);
            numericUpDown_Ymin.TabIndex = 12;
            numericUpDown_Ymin.Value = new decimal(new int[] { 2, 0, 0, int.MinValue });
            numericUpDown_Ymin.Visible = false;
            numericUpDown_Ymin.ValueChanged += numericUpDown_Ymin_ValueChanged;
            // 
            // numericUpDown_Ymax
            // 
            numericUpDown_Ymax.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Ymax.Location = new System.Drawing.Point(709, 167);
            numericUpDown_Ymax.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown_Ymax.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Ymax.Name = "numericUpDown_Ymax";
            numericUpDown_Ymax.Size = new System.Drawing.Size(93, 27);
            numericUpDown_Ymax.TabIndex = 13;
            numericUpDown_Ymax.Value = new decimal(new int[] { 4, 0, 0, 0 });
            numericUpDown_Ymax.Visible = false;
            numericUpDown_Ymax.ValueChanged += numericUpDown_Ymax_ValueChanged;
            // 
            // numericUpDown_N
            // 
            numericUpDown_N.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_N.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown_N.Location = new System.Drawing.Point(709, 222);
            numericUpDown_N.Maximum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown_N.Minimum = new decimal(new int[] { 200, 0, 0, 0 });
            numericUpDown_N.Name = "numericUpDown_N";
            numericUpDown_N.Size = new System.Drawing.Size(93, 27);
            numericUpDown_N.TabIndex = 14;
            numericUpDown_N.Value = new decimal(new int[] { 400, 0, 0, 0 });
            numericUpDown_N.ValueChanged += numericUpDown_N_ValueChanged;
            // 
            // label_Points
            // 
            label_Points.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_Points.AutoSize = true;
            label_Points.Location = new System.Drawing.Point(643, 224);
            label_Points.Name = "label_Points";
            label_Points.Size = new System.Drawing.Size(48, 20);
            label_Points.TabIndex = 15;
            label_Points.Text = "Points";
            // 
            // checkBox_F2
            // 
            checkBox_F2.AutoSize = true;
            checkBox_F2.Location = new System.Drawing.Point(698, 29);
            checkBox_F2.Name = "checkBox_F2";
            checkBox_F2.Size = new System.Drawing.Size(104, 24);
            checkBox_F2.TabIndex = 16;
            checkBox_F2.Text = "f2 (On/Off)";
            checkBox_F2.UseVisualStyleBackColor = true;
            checkBox_F2.Visible = false;
            checkBox_F2.CheckedChanged += checkBox_F2_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(828, 432);
            Controls.Add(checkBox_F2);
            Controls.Add(label_Points);
            Controls.Add(numericUpDown_N);
            Controls.Add(numericUpDown_Ymax);
            Controls.Add(numericUpDown_Ymin);
            Controls.Add(numericUpDown_Xmax);
            Controls.Add(numericUpDown_Xmin);
            Controls.Add(label_Ymax);
            Controls.Add(label_Ymin);
            Controls.Add(label_Xmax);
            Controls.Add(label_Xmin);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "y = f1(x)";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Xmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Xmax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Ymin).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Ymax).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_N).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label_Xmin;
        private System.Windows.Forms.Label label_Xmax;
        private System.Windows.Forms.Label label_Ymin;
        private System.Windows.Forms.Label label_Ymax;
        private System.Windows.Forms.NumericUpDown numericUpDown_Xmin;
        private System.Windows.Forms.NumericUpDown numericUpDown_Xmax;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ymin;
        private System.Windows.Forms.NumericUpDown numericUpDown_Ymax;
        private System.Windows.Forms.NumericUpDown numericUpDown_N;
        private System.Windows.Forms.Label label_Points;
        private System.Windows.Forms.CheckBox checkBox_F2;
    }
}

