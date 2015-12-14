using System;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public partial class RotateForm : Form
    {
        public double Angle { get; set; }
        public DialogResult DialogResult { get; set; }

        public RotateForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Angle = (double)numericUpDownAngle.Value;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
