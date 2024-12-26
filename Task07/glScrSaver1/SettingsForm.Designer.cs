namespace glScrSaver1
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            numericUpDownRotationSpeedX = new System.Windows.Forms.NumericUpDown();
            numericUpDownScaleFactor = new System.Windows.Forms.NumericUpDown();
            buttonSave = new System.Windows.Forms.Button();
            buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotationSpeedX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 83);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(232, 20);
            label1.TabIndex = 0;
            label1.Text = "Швидкість обертання по осі OX:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(142, 142);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Масштаб анімації:";
            // 
            // numericUpDownRotationSpeedX
            // 
            numericUpDownRotationSpeedX.DecimalPlaces = 1;
            numericUpDownRotationSpeedX.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownRotationSpeedX.Location = new System.Drawing.Point(286, 81);
            numericUpDownRotationSpeedX.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownRotationSpeedX.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownRotationSpeedX.Name = "numericUpDownRotationSpeedX";
            numericUpDownRotationSpeedX.Size = new System.Drawing.Size(97, 27);
            numericUpDownRotationSpeedX.TabIndex = 2;
            numericUpDownRotationSpeedX.ThousandsSeparator = true;
            numericUpDownRotationSpeedX.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // numericUpDownScaleFactor
            // 
            numericUpDownScaleFactor.DecimalPlaces = 1;
            numericUpDownScaleFactor.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownScaleFactor.Location = new System.Drawing.Point(284, 142);
            numericUpDownScaleFactor.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDownScaleFactor.Minimum = new decimal(new int[] { 1, 0, 0, 65536 });
            numericUpDownScaleFactor.Name = "numericUpDownScaleFactor";
            numericUpDownScaleFactor.Size = new System.Drawing.Size(102, 27);
            numericUpDownScaleFactor.TabIndex = 3;
            numericUpDownScaleFactor.ThousandsSeparator = true;
            numericUpDownScaleFactor.Value = new decimal(new int[] { 1, 0, 0, 65536 });
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(57, 249);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(94, 29);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Зберегти";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new System.Drawing.Point(284, 254);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new System.Drawing.Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Вийти";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(439, 348);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownScaleFactor);
            Controls.Add(numericUpDownRotationSpeedX);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "SettingsForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosed += SettingsFormClosed;
            Load += SettingsFormLoad;
            ((System.ComponentModel.ISupportInitialize)numericUpDownRotationSpeedX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownScaleFactor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownRotationSpeedX;
        private System.Windows.Forms.NumericUpDown numericUpDownScaleFactor;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}