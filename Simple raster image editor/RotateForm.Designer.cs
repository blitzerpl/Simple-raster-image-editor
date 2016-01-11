namespace Simple_raster_image_editor
{
    partial class RotateForm
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
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.labelAngle = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(93, 7);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownAngle.TabIndex = 8;
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(50, 9);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(37, 13);
            this.labelAngle.TabIndex = 7;
            this.labelAngle.Text = "Angle:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(93, 42);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 10;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(12, 42);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 9;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // RotateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 75);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownAngle);
            this.Controls.Add(this.labelAngle);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(192, 114);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(192, 114);
            this.Name = "RotateForm";
            this.ShowIcon = false;
            this.Text = "Rotate";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownAngle;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonOK;
    }
}