using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public partial class ResizeForm : Form
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public DialogResult DialogResult { get; set; }

        public ResizeForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Width = (int)numericUpDownWidth.Value;
            Height = (int)numericUpDownHeight.Value;
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
