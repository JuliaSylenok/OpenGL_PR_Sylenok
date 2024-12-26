
using System.ComponentModel;
using System.Drawing;

namespace glScrSaver1
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
            components = new Container();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 16;
            timer.Tick += timer_Tick;
            // 
            // RenderControl
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            BackColor = Color.SlateGray;
            ForeColor = Color.White;
            Name = "RenderControl";
            Size = new Size(480, 300);
            TextCodePage = 1251;
            Render += OnRender;
            ContextCreated += OnContextCreated;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer;
    }
}
