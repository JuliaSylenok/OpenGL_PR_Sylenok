
namespace gl_Lab5
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
            renderControl1 = new RenderControl();
            radioButton_Fill = new System.Windows.Forms.RadioButton();
            radioButton_Line = new System.Windows.Forms.RadioButton();
            checkBox_Ortho_or_Perspective = new System.Windows.Forms.CheckBox();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Font = new System.Drawing.Font("Times New Roman", 7F);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.IsWireframe = true;
            renderControl1.Location = new System.Drawing.Point(22, 6);
            renderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            renderControl1.Name = "renderControl1";
            renderControl1.OrthoPerspective = true;
            renderControl1.Size = new System.Drawing.Size(749, 559);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // radioButton_Fill
            // 
            radioButton_Fill.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton_Fill.AutoSize = true;
            radioButton_Fill.Location = new System.Drawing.Point(815, 132);
            radioButton_Fill.Name = "radioButton_Fill";
            radioButton_Fill.Size = new System.Drawing.Size(46, 21);
            radioButton_Fill.TabIndex = 4;
            radioButton_Fill.Text = "Fill";
            radioButton_Fill.UseVisualStyleBackColor = true;
            radioButton_Fill.CheckedChanged += radioButton_Fill_CheckedChanged;
            // 
            // radioButton_Line
            // 
            radioButton_Line.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            radioButton_Line.AutoSize = true;
            radioButton_Line.Location = new System.Drawing.Point(815, 159);
            radioButton_Line.Name = "radioButton_Line";
            radioButton_Line.Size = new System.Drawing.Size(55, 21);
            radioButton_Line.TabIndex = 5;
            radioButton_Line.Text = "Line";
            radioButton_Line.UseVisualStyleBackColor = true;
            radioButton_Line.CheckedChanged += radioButton_Line_CheckedChanged;
            // 
            // checkBox_Ortho_or_Perspective
            // 
            checkBox_Ortho_or_Perspective.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            checkBox_Ortho_or_Perspective.AutoSize = true;
            checkBox_Ortho_or_Perspective.Location = new System.Drawing.Point(815, 203);
            checkBox_Ortho_or_Perspective.Name = "checkBox_Ortho_or_Perspective";
            checkBox_Ortho_or_Perspective.Size = new System.Drawing.Size(137, 21);
            checkBox_Ortho_or_Perspective.TabIndex = 6;
            checkBox_Ortho_or_Perspective.Text = "Ortho/Perspective";
            checkBox_Ortho_or_Perspective.UseVisualStyleBackColor = true;
            checkBox_Ortho_or_Perspective.CheckedChanged += checkBox_Ortho_or_Perspective_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1044, 578);
            Controls.Add(checkBox_Ortho_or_Perspective);
            Controls.Add(radioButton_Line);
            Controls.Add(radioButton_Fill);
            Controls.Add(renderControl1);
            Font = new System.Drawing.Font("Times New Roman", 9F);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.RadioButton radioButton_Fill;
        private System.Windows.Forms.RadioButton radioButton_Line;
        private System.Windows.Forms.CheckBox checkBox_Ortho_or_Perspective;
    }
}

