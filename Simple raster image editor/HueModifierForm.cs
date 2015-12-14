using System;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public partial class HueModifierForm : Form
    {
        public int HueValue { get; set; }
        public DialogResult DialogResult { get; set; }

        public HueModifierForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            HueValue = (int)numericUpDownHue.Value;
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
