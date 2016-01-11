namespace Simple_raster_image_editor
{
    partial class BrightnessForm
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
            this.buttonBack = new System.Windows.Forms.Button();
            this.numericUpDownHue = new System.Windows.Forms.NumericUpDown();
            this.labelHue = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(122, 36);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // numericUpDownHue
            // 
            this.numericUpDownHue.Location = new System.Drawing.Point(109, 7);
            this.numericUpDownHue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numericUpDownHue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.numericUpDownHue.Name = "numericUpDownHue";
            this.numericUpDownHue.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownHue.TabIndex = 6;
            // 
            // labelHue
            // 
            this.labelHue.AutoSize = true;
            this.labelHue.Location = new System.Drawing.Point(12, 9);
            this.labelHue.Name = "labelHue";
            this.labelHue.Size = new System.Drawing.Size(88, 13);
            this.labelHue.TabIndex = 5;
            this.labelHue.Text = "Brightness value:";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(15, 36);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // BrightnessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 67);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.numericUpDownHue);
            this.Controls.Add(this.labelHue);
            this.Controls.Add(this.buttonOK);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(226, 105);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(226, 105);
            this.Name = "BrightnessForm";
            this.ShowIcon = false;
            this.Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.NumericUpDown numericUpDownHue;
        private System.Windows.Forms.Label labelHue;
        private System.Windows.Forms.Button buttonOK;
    }
}