
namespace gl_Lab4
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
            label_text = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numeric_Parabola = new System.Windows.Forms.NumericUpDown();
            numeric_Elips = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numeric_Parabola).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Elips).BeginInit();
            SuspendLayout();
            // 
            // renderControl1
            // 
            renderControl1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            renderControl1.BackColor = System.Drawing.Color.SlateGray;
            renderControl1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 204);
            renderControl1.ForeColor = System.Drawing.Color.White;
            renderControl1.Location = new System.Drawing.Point(24, 32);
            renderControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            renderControl1.Name = "renderControl1";
            renderControl1.SegmentsEllipse = 5;
            renderControl1.SegmentsParabola = 5;
            renderControl1.Size = new System.Drawing.Size(600, 375);
            renderControl1.TabIndex = 0;
            renderControl1.TextCodePage = 1251;
            // 
            // label_text
            // 
            label_text.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label_text.AutoSize = true;
            label_text.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label_text.Location = new System.Drawing.Point(713, 32);
            label_text.Name = "label_text";
            label_text.Size = new System.Drawing.Size(148, 20);
            label_text.TabIndex = 3;
            label_text.Text = "Кількість сегментів";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label1.Location = new System.Drawing.Point(696, 69);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(84, 20);
            label1.TabIndex = 4;
            label1.Text = "Парабола:";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(713, 120);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Еліпс:";
            // 
            // numeric_Parabola
            // 
            numeric_Parabola.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numeric_Parabola.Location = new System.Drawing.Point(797, 68);
            numeric_Parabola.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_Parabola.Name = "numeric_Parabola";
            numeric_Parabola.Size = new System.Drawing.Size(83, 27);
            numeric_Parabola.TabIndex = 6;
            numeric_Parabola.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_Parabola.ValueChanged += numeric_Parabola_ValueChanged;
            // 
            // numeric_Elips
            // 
            numeric_Elips.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            numeric_Elips.Location = new System.Drawing.Point(797, 113);
            numeric_Elips.Minimum = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_Elips.Name = "numeric_Elips";
            numeric_Elips.Size = new System.Drawing.Size(83, 27);
            numeric_Elips.TabIndex = 7;
            numeric_Elips.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numeric_Elips.ValueChanged += numeric_Elips_ValueChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(912, 432);
            Controls.Add(numeric_Elips);
            Controls.Add(numeric_Parabola);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label_text);
            Controls.Add(renderControl1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "lab4 Sylenok";
            ((System.ComponentModel.ISupportInitialize)numeric_Parabola).EndInit();
            ((System.ComponentModel.ISupportInitialize)numeric_Elips).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RenderControl renderControl1;
        private System.Windows.Forms.Label label_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numeric_Parabola;
        private System.Windows.Forms.NumericUpDown numeric_Elips;
    }
}

