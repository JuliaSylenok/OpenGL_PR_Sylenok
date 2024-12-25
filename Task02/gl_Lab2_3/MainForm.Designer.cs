
namespace gl_Lab2_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new System.Windows.Forms.Label();
            numericUpDown_Horizont = new System.Windows.Forms.NumericUpDown();
            numericUpDown_Vertical = new System.Windows.Forms.NumericUpDown();
            radioButton_Fill = new System.Windows.Forms.RadioButton();
            radioButton_Line = new System.Windows.Forms.RadioButton();
            radioButton_Points = new System.Windows.Forms.RadioButton();
            renderControl1 = new RenderControl();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Horizont).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Vertical).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(703, 32);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 20);
            label1.TabIndex = 1;
            label1.Text = "Горизонталь:";
            // 
            // numericUpDown_Horizont
            // 
            numericUpDown_Horizont.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Horizont.Location = new System.Drawing.Point(703, 55);
            numericUpDown_Horizont.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Horizont.Name = "numericUpDown_Horizont";
            numericUpDown_Horizont.Size = new System.Drawing.Size(150, 27);
            numericUpDown_Horizont.TabIndex = 3;
            numericUpDown_Horizont.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Horizont.ValueChanged += numericUpDown_Horizont_ValueChanged;
            // 
            // numericUpDown_Vertical
            // 
            numericUpDown_Vertical.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numericUpDown_Vertical.Location = new System.Drawing.Point(703, 113);
            numericUpDown_Vertical.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Vertical.Name = "numericUpDown_Vertical";
            numericUpDown_Vertical.Size = new System.Drawing.Size(150, 27);
            numericUpDown_Vertical.TabIndex = 4;
            numericUpDown_Vertical.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Vertical.ValueChanged += numericUpDown_Vertical_ValueChanged;
            // 
            // radioButton_Fill
            // 
            radioButton_Fill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            radioButton_Fill.AutoSize = true;
            radioButton_Fill.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            radioButton_Fill.Location = new System.Drawing.Point(703, 158);
            radioButton_Fill.Name = "radioButton_Fill";
            radioButton_Fill.Size = new System.Drawing.Size(50, 24);
            radioButton_Fill.TabIndex = 5;
            radioButton_Fill.TabStop = true;
            radioButton_Fill.Text = "Fill";
            radioButton_Fill.UseVisualStyleBackColor = true;
            radioButton_Fill.CheckedChanged += radioButton_Fill_CheckedChanged;
            // 
            // radioButton_Line
            // 
            radioButton_Line.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            radioButton_Line.AutoSize = true;
            radioButton_Line.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            radioButton_Line.Location = new System.Drawing.Point(703, 188);
            radioButton_Line.Name = "radioButton_Line";
            radioButton_Line.Size = new System.Drawing.Size(59, 24);
            radioButton_Line.TabIndex = 6;
            radioButton_Line.TabStop = true;
            radioButton_Line.Text = "Line";
            radioButton_Line.UseVisualStyleBackColor = true;
            radioButton_Line.CheckedChanged += radioButton_Line_CheckedChanged;
            // 
            // radioButton_Points
            // 
            radioButton_Points.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            radioButton_Points.AutoSize = true;
            radioButton_Points.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            radioButton_Points.Location = new System.Drawing.Point(703, 218);
            radioButton_Points.Name = "radioButton_Points";
            radioButton_Points.Size = new System.Drawing.Size(74, 24);
            radioButton_Points.TabIndex = 7;
            radioButton_Points.TabStop = true;
            radioButton_Points.Text = "Points";
            radioButton_Points.UseVisualStyleBackColor = true;
            radioButton_Points.CheckedChanged += radioButton_Points_CheckedChanged;
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(12, 22);
            renderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            renderControl1.Name = "renderControl1";
            renderControl1.Size = new System.Drawing.Size(600, 375);
            renderControl1.TabIndex = 8;
            renderControl1.TextCodePage = 1251;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(703, 90);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(89, 20);
            label2.TabIndex = 9;
            label2.Text = "Вертикаль:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(866, 432);
            Controls.Add(label2);
            Controls.Add(renderControl1);
            Controls.Add(radioButton_Points);
            Controls.Add(radioButton_Line);
            Controls.Add(radioButton_Fill);
            Controls.Add(numericUpDown_Vertical);
            Controls.Add(numericUpDown_Horizont);
            Controls.Add(label1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Lab 2 Sylenok";
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Horizont).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Vertical).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_Horizont;
        private System.Windows.Forms.NumericUpDown numericUpDown_Vertical;
        private System.Windows.Forms.RadioButton radioButton_Fill;
        private System.Windows.Forms.RadioButton radioButton_Line;
        private System.Windows.Forms.RadioButton radioButton_Points;
        private RenderControl renderControl1;
        private System.Windows.Forms.Label label2;
    }
}

