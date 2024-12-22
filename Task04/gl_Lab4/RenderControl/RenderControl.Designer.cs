
using System.ComponentModel;
using System.Drawing;

namespace gl_Lab4
{
    [ToolboxItem(true), ToolboxBitmap(typeof(RenderControl), "RenderControl.bmp"), DefaultEvent("")]
    partial class RenderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // RenderControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = Color.SlateGray;
            Font = new Font("Times New Roman", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Name = "RenderControl";
            Size = new Size(480, 300);
            TextCodePage = 1251;
            Render += OnRender;
            MouseClick += OnMouseClick;
            ResumeLayout(false);
        }

        #endregion
    }
}
