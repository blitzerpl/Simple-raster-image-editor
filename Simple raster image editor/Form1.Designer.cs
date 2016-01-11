namespace Simple_raster_image_editor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImage = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageRotate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recoloringFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuImageRecolorGrayscale = new System.Windows.Forms.ToolStripMenuItem();
            this.sepiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hueModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateChannelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.edgeDetectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageEdgeDetectorsHomogenity = new System.Windows.Forms.ToolStripMenuItem();
            this.differenceEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobelEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cannyEdgeDetectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linearColorCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastCorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusImageName = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileNameContent = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusFileSizeContent = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSize = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusImageSizeContent = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDrawing = new System.Windows.Forms.ToolStrip();
            this.buttonPencil = new System.Windows.Forms.ToolStripButton();
            this.buttonRubber = new System.Windows.Forms.ToolStripButton();
            this.buttonLine = new System.Windows.Forms.ToolStripButton();
            this.buttonRectangle = new System.Windows.Forms.ToolStripButton();
            this.buttonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.buttonColorDialog = new System.Windows.Forms.ToolStripButton();
            this.textBoxColor = new System.Windows.Forms.ToolStripTextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelBlue = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelGreen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelRed = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStripDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.LemonChiffon;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuImage});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip.Stretch = false;
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileNew,
            this.menuFileOpen,
            this.menuFileSave});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // menuFileNew
            // 
            this.menuFileNew.Name = "menuFileNew";
            this.menuFileNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuFileNew.Size = new System.Drawing.Size(146, 22);
            this.menuFileNew.Text = "New";
            this.menuFileNew.Click += new System.EventHandler(this.menuFileNew_Click);
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuFileOpen.Size = new System.Drawing.Size(146, 22);
            this.menuFileOpen.Text = "Open";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuFileSave
            // 
            this.menuFileSave.Name = "menuFileSave";
            this.menuFileSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuFileSave.Size = new System.Drawing.Size(146, 22);
            this.menuFileSave.Text = "Save";
            this.menuFileSave.Click += new System.EventHandler(this.menuFileSave_Click);
            // 
            // menuImage
            // 
            this.menuImage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.imageRotate,
            this.toolStripSeparator2,
            this.recoloringFiltersToolStripMenuItem,
            this.edgeDetectorsToolStripMenuItem,
            this.linearColorCorrectionToolStripMenuItem});
            this.menuImage.Name = "menuImage";
            this.menuImage.Size = new System.Drawing.Size(52, 20);
            this.menuImage.Text = "Image";
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.resizeToolStripMenuItem.Text = "Resize";
            this.resizeToolStripMenuItem.Click += new System.EventHandler(this.resizeToolStripMenuItem_Click);
            // 
            // imageRotate
            // 
            this.imageRotate.Name = "imageRotate";
            this.imageRotate.Size = new System.Drawing.Size(193, 22);
            this.imageRotate.Text = "Rotate";
            this.imageRotate.Click += new System.EventHandler(this.imageRotate_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // recoloringFiltersToolStripMenuItem
            // 
            this.recoloringFiltersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuImageRecolorGrayscale,
            this.sepiaToolStripMenuItem,
            this.hueModifierToolStripMenuItem,
            this.rotateChannelsToolStripMenuItem,
            this.invertToolStripMenuItem});
            this.recoloringFiltersToolStripMenuItem.Name = "recoloringFiltersToolStripMenuItem";
            this.recoloringFiltersToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.recoloringFiltersToolStripMenuItem.Text = "Re-coloring filters";
            // 
            // menuImageRecolorGrayscale
            // 
            this.menuImageRecolorGrayscale.Name = "menuImageRecolorGrayscale";
            this.menuImageRecolorGrayscale.Size = new System.Drawing.Size(160, 22);
            this.menuImageRecolorGrayscale.Text = "Greyscale";
            this.menuImageRecolorGrayscale.Click += new System.EventHandler(this.menuImageRecolorGrayscale_Click);
            // 
            // sepiaToolStripMenuItem
            // 
            this.sepiaToolStripMenuItem.Name = "sepiaToolStripMenuItem";
            this.sepiaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sepiaToolStripMenuItem.Text = "Sepia";
            this.sepiaToolStripMenuItem.Click += new System.EventHandler(this.sepiaToolStripMenuItem_Click);
            // 
            // hueModifierToolStripMenuItem
            // 
            this.hueModifierToolStripMenuItem.Name = "hueModifierToolStripMenuItem";
            this.hueModifierToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hueModifierToolStripMenuItem.Text = "Hue Modifier";
            this.hueModifierToolStripMenuItem.Click += new System.EventHandler(this.hueModifierToolStripMenuItem_Click);
            // 
            // rotateChannelsToolStripMenuItem
            // 
            this.rotateChannelsToolStripMenuItem.Name = "rotateChannelsToolStripMenuItem";
            this.rotateChannelsToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.rotateChannelsToolStripMenuItem.Text = "Rotate Channels";
            this.rotateChannelsToolStripMenuItem.Click += new System.EventHandler(this.rotateChannelsToolStripMenuItem_Click);
            // 
            // invertToolStripMenuItem
            // 
            this.invertToolStripMenuItem.Name = "invertToolStripMenuItem";
            this.invertToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.invertToolStripMenuItem.Text = "Invert";
            this.invertToolStripMenuItem.Click += new System.EventHandler(this.invertToolStripMenuItem_Click);
            // 
            // edgeDetectorsToolStripMenuItem
            // 
            this.edgeDetectorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageEdgeDetectorsHomogenity,
            this.differenceEdgeDetectorToolStripMenuItem,
            this.sobelEdgeDetectorToolStripMenuItem,
            this.cannyEdgeDetectorToolStripMenuItem});
            this.edgeDetectorsToolStripMenuItem.Name = "edgeDetectorsToolStripMenuItem";
            this.edgeDetectorsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.edgeDetectorsToolStripMenuItem.Text = "Edge detectors";
            // 
            // imageEdgeDetectorsHomogenity
            // 
            this.imageEdgeDetectorsHomogenity.Name = "imageEdgeDetectorsHomogenity";
            this.imageEdgeDetectorsHomogenity.Size = new System.Drawing.Size(217, 22);
            this.imageEdgeDetectorsHomogenity.Text = "Homogenity edge detector";
            this.imageEdgeDetectorsHomogenity.Click += new System.EventHandler(this.imageEdgeDetectorsHomogenity_Click);
            // 
            // differenceEdgeDetectorToolStripMenuItem
            // 
            this.differenceEdgeDetectorToolStripMenuItem.Name = "differenceEdgeDetectorToolStripMenuItem";
            this.differenceEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.differenceEdgeDetectorToolStripMenuItem.Text = "Difference edge detector";
            this.differenceEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.differenceEdgeDetectorToolStripMenuItem_Click);
            // 
            // sobelEdgeDetectorToolStripMenuItem
            // 
            this.sobelEdgeDetectorToolStripMenuItem.Name = "sobelEdgeDetectorToolStripMenuItem";
            this.sobelEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.sobelEdgeDetectorToolStripMenuItem.Text = "Sobel edge detector";
            this.sobelEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.sobelEdgeDetectorToolStripMenuItem_Click);
            // 
            // cannyEdgeDetectorToolStripMenuItem
            // 
            this.cannyEdgeDetectorToolStripMenuItem.Name = "cannyEdgeDetectorToolStripMenuItem";
            this.cannyEdgeDetectorToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.cannyEdgeDetectorToolStripMenuItem.Text = "Canny edge detector";
            this.cannyEdgeDetectorToolStripMenuItem.Click += new System.EventHandler(this.cannyEdgeDetectorToolStripMenuItem_Click);
            // 
            // linearColorCorrectionToolStripMenuItem
            // 
            this.linearColorCorrectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessCorrectionToolStripMenuItem,
            this.contrastCorrectionToolStripMenuItem});
            this.linearColorCorrectionToolStripMenuItem.Name = "linearColorCorrectionToolStripMenuItem";
            this.linearColorCorrectionToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.linearColorCorrectionToolStripMenuItem.Text = "Linear color correction";
            // 
            // brightnessCorrectionToolStripMenuItem
            // 
            this.brightnessCorrectionToolStripMenuItem.Name = "brightnessCorrectionToolStripMenuItem";
            this.brightnessCorrectionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.brightnessCorrectionToolStripMenuItem.Text = "Brightness correction";
            this.brightnessCorrectionToolStripMenuItem.Click += new System.EventHandler(this.brightnessCorrectionToolStripMenuItem_Click);
            // 
            // contrastCorrectionToolStripMenuItem
            // 
            this.contrastCorrectionToolStripMenuItem.Name = "contrastCorrectionToolStripMenuItem";
            this.contrastCorrectionToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.contrastCorrectionToolStripMenuItem.Text = "Contrast correction";
            this.contrastCorrectionToolStripMenuItem.Click += new System.EventHandler(this.contrastCorrectionToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.LemonChiffon;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusImageName,
            this.statusFileNameContent,
            this.statusFileSize,
            this.statusFileSizeContent,
            this.statusImageSize,
            this.statusImageSizeContent,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabelRed,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabelGreen,
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelBlue});
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1008, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusImageName
            // 
            this.statusImageName.Name = "statusImageName";
            this.statusImageName.Size = new System.Drawing.Size(61, 17);
            this.statusImageName.Text = "File name:";
            // 
            // statusFileNameContent
            // 
            this.statusFileNameContent.Name = "statusFileNameContent";
            this.statusFileNameContent.Size = new System.Drawing.Size(37, 17);
            this.statusFileNameContent.Text = "          ";
            // 
            // statusFileSize
            // 
            this.statusFileSize.Name = "statusFileSize";
            this.statusFileSize.Size = new System.Drawing.Size(50, 17);
            this.statusFileSize.Text = "File size:";
            // 
            // statusFileSizeContent
            // 
            this.statusFileSizeContent.Name = "statusFileSizeContent";
            this.statusFileSizeContent.Size = new System.Drawing.Size(37, 17);
            this.statusFileSizeContent.Text = "          ";
            // 
            // statusImageSize
            // 
            this.statusImageSize.Name = "statusImageSize";
            this.statusImageSize.Size = new System.Drawing.Size(65, 17);
            this.statusImageSize.Text = "Image size:";
            // 
            // statusImageSizeContent
            // 
            this.statusImageSizeContent.Name = "statusImageSizeContent";
            this.statusImageSizeContent.Size = new System.Drawing.Size(37, 17);
            this.statusImageSizeContent.Text = "          ";
            // 
            // toolStripDrawing
            // 
            this.toolStripDrawing.BackColor = System.Drawing.Color.LemonChiffon;
            this.toolStripDrawing.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripDrawing.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonPencil,
            this.buttonRubber,
            this.buttonLine,
            this.buttonRectangle,
            this.buttonEllipse,
            this.toolStripSeparator1,
            this.buttonColorDialog,
            this.textBoxColor});
            this.toolStripDrawing.Location = new System.Drawing.Point(0, 24);
            this.toolStripDrawing.Name = "toolStripDrawing";
            this.toolStripDrawing.Size = new System.Drawing.Size(24, 516);
            this.toolStripDrawing.TabIndex = 2;
            this.toolStripDrawing.Text = "toolStrip1";
            // 
            // buttonPencil
            // 
            this.buttonPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonPencil.Image = ((System.Drawing.Image)(resources.GetObject("buttonPencil.Image")));
            this.buttonPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonPencil.Name = "buttonPencil";
            this.buttonPencil.Size = new System.Drawing.Size(21, 20);
            this.buttonPencil.ToolTipText = "Pencil";
            this.buttonPencil.Click += new System.EventHandler(this.buttonPencil_Click);
            // 
            // buttonRubber
            // 
            this.buttonRubber.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRubber.Image = ((System.Drawing.Image)(resources.GetObject("buttonRubber.Image")));
            this.buttonRubber.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRubber.Name = "buttonRubber";
            this.buttonRubber.Size = new System.Drawing.Size(21, 20);
            this.buttonRubber.ToolTipText = "Rubber";
            this.buttonRubber.Click += new System.EventHandler(this.buttonRubber_Click);
            // 
            // buttonLine
            // 
            this.buttonLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonLine.Image = ((System.Drawing.Image)(resources.GetObject("buttonLine.Image")));
            this.buttonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonLine.Name = "buttonLine";
            this.buttonLine.Size = new System.Drawing.Size(21, 20);
            this.buttonLine.ToolTipText = "Line";
            this.buttonLine.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // buttonRectangle
            // 
            this.buttonRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRectangle.Image = ((System.Drawing.Image)(resources.GetObject("buttonRectangle.Image")));
            this.buttonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRectangle.Name = "buttonRectangle";
            this.buttonRectangle.Size = new System.Drawing.Size(21, 20);
            this.buttonRectangle.ToolTipText = "Rectangle";
            this.buttonRectangle.Click += new System.EventHandler(this.buttonRectangle_Click);
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonEllipse.Image = ((System.Drawing.Image)(resources.GetObject("buttonEllipse.Image")));
            this.buttonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(21, 20);
            this.buttonEllipse.ToolTipText = "Ellipse";
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(21, 6);
            // 
            // buttonColorDialog
            // 
            this.buttonColorDialog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonColorDialog.Image = ((System.Drawing.Image)(resources.GetObject("buttonColorDialog.Image")));
            this.buttonColorDialog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonColorDialog.Name = "buttonColorDialog";
            this.buttonColorDialog.Size = new System.Drawing.Size(21, 20);
            this.buttonColorDialog.ToolTipText = "Color picker";
            this.buttonColorDialog.Click += new System.EventHandler(this.buttonColorDialog_Click);
            // 
            // textBoxColor
            // 
            this.textBoxColor.BackColor = System.Drawing.Color.White;
            this.textBoxColor.Enabled = false;
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(19, 23);
            this.textBoxColor.ToolTipText = "Picked color";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.MaximumSize = new System.Drawing.Size(982, 515);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(0, 0);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseDown);
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(33, 17);
            this.toolStripStatusLabel1.Text = "Blue:";
            // 
            // toolStripStatusLabelBlue
            // 
            this.toolStripStatusLabelBlue.Name = "toolStripStatusLabelBlue";
            this.toolStripStatusLabelBlue.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabelBlue.Text = "      ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 17);
            this.toolStripStatusLabel3.Text = "Green:";
            // 
            // toolStripStatusLabelGreen
            // 
            this.toolStripStatusLabelGreen.Name = "toolStripStatusLabelGreen";
            this.toolStripStatusLabelGreen.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabelGreen.Text = "      ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(30, 17);
            this.toolStripStatusLabel5.Text = "Red:";
            // 
            // toolStripStatusLabelRed
            // 
            this.toolStripStatusLabelRed.Name = "toolStripStatusLabelRed";
            this.toolStripStatusLabelRed.Size = new System.Drawing.Size(25, 17);
            this.toolStripStatusLabelRed.Text = "      ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.toolStripDrawing);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1024, 600);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "Form1";
            this.Text = "Simple raster image editor";
            this.TransparencyKey = System.Drawing.SystemColors.HotTrack;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripDrawing.ResumeLayout(false);
            this.toolStripDrawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileNew;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuFileSave;
        private System.Windows.Forms.ToolStripMenuItem menuImage;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusImageName;
        private System.Windows.Forms.ToolStripStatusLabel statusFileNameContent;
        private System.Windows.Forms.ToolStripStatusLabel statusFileSize;
        private System.Windows.Forms.ToolStripStatusLabel statusFileSizeContent;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSize;
        private System.Windows.Forms.ToolStripStatusLabel statusImageSizeContent;
        private System.Windows.Forms.ToolStrip toolStripDrawing;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ToolStripButton buttonPencil;
        private System.Windows.Forms.ToolStripButton buttonRubber;
        private System.Windows.Forms.ToolStripButton buttonColorDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolStripTextBox textBoxColor;
        private System.Windows.Forms.ToolStripButton buttonLine;
        private System.Windows.Forms.ToolStripButton buttonRectangle;
        private System.Windows.Forms.ToolStripButton buttonEllipse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem recoloringFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuImageRecolorGrayscale;
        private System.Windows.Forms.ToolStripMenuItem sepiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hueModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateChannelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem edgeDetectorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageEdgeDetectorsHomogenity;
        private System.Windows.Forms.ToolStripMenuItem differenceEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobelEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cannyEdgeDetectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageRotate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem linearColorCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastCorrectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelRed;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGreen;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelBlue;
    }
}

