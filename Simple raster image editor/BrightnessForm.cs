﻿using System;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public partial class BrightnessForm : Form
    {
        public int BrightnessValue { get; set; }
        public DialogResult DialogResult { get; set; }

        public BrightnessForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            BrightnessValue = (int)numericUpDownHue.Value;
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
