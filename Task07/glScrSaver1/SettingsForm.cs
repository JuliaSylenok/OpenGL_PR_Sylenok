using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace glScrSaver1
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            numericUpDownRotationSpeedX.Value = (decimal)AppSettings.RotationSpeedX;
            numericUpDownScaleFactor.Value = (decimal)AppSettings.ScaleFactor;
        }

        private void SettingsFormLoad(object sender, EventArgs e)
        {
            try
            {
                numericUpDownRotationSpeedX.Value = (decimal)AppSettings.RotationSpeedX;
                numericUpDownScaleFactor.Value = (decimal)AppSettings.ScaleFactor;
                Debug.WriteLine("Settings loaded successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SettingsFormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                AppSettings.RotationSpeedX = (double)numericUpDownRotationSpeedX.Value;
                AppSettings.ScaleFactor = (double)numericUpDownScaleFactor.Value;
                Debug.WriteLine("Settings saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving settings: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
