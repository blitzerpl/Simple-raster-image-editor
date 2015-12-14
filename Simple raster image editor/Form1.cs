using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public partial class Form1 : Form
    {
        private const long _oneKb = 1024;
        private Color _color;
        private Point? _previous = null;
        private Item currItem;
        private Pen _pen = null;
        private bool draw = false;

        private enum Item
        {
            Pencil, Rubber, Line, Rectangle, Ellipse
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void menuFileNew_Click(object sender, EventArgs e)
        {
            pictureBox.Refresh();
            Bitmap bm = new Bitmap(982, 515);
            pictureBox.Image = bm;
            CenterPictureBox();
        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "All files|*.*|PNG|*.png|JPEG|*jpg|Bitmap|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (Image.FromFile(o.FileName).Width < 800 || Image.FromFile(o.FileName).Height < 600)
                {
                    pictureBox.Image = (Image)Image.FromFile(o.FileName).Clone();

                    statusFileNameContent.Text = Path.GetFileName(o.FileName) + "     ";
                    statusFileSizeContent.Text = Math.Round((double)new FileInfo(o.FileName).Length / _oneKb, 2).ToString() + " KB     ";
                    statusImageSizeContent.Text = pictureBox.Image.Size.Width.ToString() + " : " + pictureBox.Image.Size.Height.ToString();
                    CenterPictureBox();
                }
                else
                {
                    MessageBox.Show("Image is too big (max 800x600)", "Warning");
                }
            }
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics g = Graphics.FromImage(bmp);
                Rectangle rect = pictureBox.RectangleToScreen(pictureBox.ClientRectangle);
                g.CopyFromScreen(rect.Location, Point.Empty, pictureBox.Size);
                g.Dispose();
                SaveFileDialog s = new SaveFileDialog();
                s.Filter = "PNG | *.png |JPEG | *jpg |Bitmap | *.bmp";
                if (s.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    if (File.Exists(s.FileName))
                    {
                        File.Delete(s.FileName);
                    }
                    if (s.FileName.Contains(".jpg"))
                    {
                        bmp.Save(s.FileName, ImageFormat.Jpeg);
                    }
                    else if (s.FileName.Contains(".png"))
                    {
                        bmp.Save(s.FileName, ImageFormat.Png);
                    }
                    else if (s.FileName.Contains(".bmp"))
                    {
                        bmp.Save(s.FileName, ImageFormat.Bmp);
                    }
                }
            }
            else
            {
                MessageBox.Show("You can't save empty picture.", "Warning");
            }
        }

        private void CenterPictureBox()
        {
            pictureBox.Location = new Point(((pictureBox.Parent.ClientSize.Width + toolStripDrawing.Width) / 2) - (pictureBox.Image.Width / 2),
                                        ((pictureBox.Parent.ClientSize.Height + menuStrip.Height) / 2) - (pictureBox.Image.Height / 2));
            pictureBox.Refresh();
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            SetPencil();
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            SetRubber();
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            SetLine();
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            SetRectangle();
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            SetEllipse();
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _color = colorDialog.Color;
            textBoxColor.BackColor = _color;

            switch(currItem)
            {
                case Item.Pencil:
                    SetPencil();
                    break;
                case Item.Rubber:
                    SetRubber();
                    break;
                case Item.Line:
                    SetLine();
                    break;
                case Item.Rectangle:
                    SetRectangle();
                    break;
                case Item.Ellipse:
                    SetEllipse();
                    break;
            }
        }

        private void SetPencil()
        {
            currItem = Item.Pencil;
            _pen = new Pen(_color, 2);
            _pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }

        private void SetRubber()
        {
            currItem = Item.Rubber;
            _pen = new Pen(Color.White, 10);
            _pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }

        private void SetLine()
        {
            currItem = Item.Line;
            _pen = new Pen(_color, 3);
        }

        private void SetRectangle()
        {
            currItem = Item.Rectangle;
            _pen = new Pen(_color, 3);
        }

        private void SetEllipse()
        {
            currItem = Item.Ellipse;
            _pen = new Pen(_color, 3);
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            _previous = new Point(e.X, e.Y);
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                using (Graphics g = pictureBox.CreateGraphics())
                {
                    switch (currItem)
                    {
                        case Item.Pencil:
                            g.DrawLine(_pen, _previous.Value.X, _previous.Value.Y, e.X, e.Y);
                            _previous = new Point(e.X, e.Y);
                            break;
                        case Item.Rubber:
                            g.DrawLine(_pen, _previous.Value.X, _previous.Value.Y, e.X, e.Y);
                            _previous = new Point(e.X, e.Y);
                            break;
                    }
                    g.Dispose();              
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
            using (Graphics g = pictureBox.CreateGraphics())
            {
                switch (currItem)
                {
                    case Item.Line:
                        g.DrawLine(_pen, _previous.Value.X, _previous.Value.Y, e.X, e.Y);
                        break;
                    case Item.Rectangle:
                        g.DrawRectangle(_pen, _previous.Value.X, _previous.Value.Y, e.X - _previous.Value.X, e.Y - _previous.Value.Y);
                        break;
                    case Item.Ellipse:
                        g.DrawEllipse(_pen, _previous.Value.X, _previous.Value.Y, e.X - _previous.Value.X, e.Y - _previous.Value.Y);
                        break;
                }
                g.Dispose();
            }
            _previous = null;
        }

        private void resizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ResizeForm resizeForm = new ResizeForm())
            {
                resizeForm.StartPosition = FormStartPosition.CenterParent;
                resizeForm.ShowDialog();
                if (resizeForm.DialogResult == DialogResult.OK)
                {
                    ImageEditor.ResizeBilinearImage(pictureBox, resizeForm.Width, resizeForm.Height);

                    statusImageSizeContent.Text = pictureBox.Image.Size.Width.ToString() + " : " + pictureBox.Image.Size.Height.ToString();
                    CenterPictureBox();
                }
            }
        }

        private void imageRotate_Click(object sender, EventArgs e)
        {
            using (RotateForm rotateForm = new RotateForm())
            {
                rotateForm.StartPosition = FormStartPosition.CenterParent;
                rotateForm.ShowDialog();
                if (rotateForm.DialogResult == DialogResult.OK)
                {
                    ImageEditor.RotateBilinear(pictureBox, rotateForm.Angle);
                }
            }
        }

        private void menuImageRecolorGrayscale_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ImageEditor.ConvertToGrayscale(pictureBox);
            }
        }

        private void sepiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ImageEditor.ConvertToSepia(pictureBox);
            }
        }

        private void hueModifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                using (HueModifierForm hueModifierForm = new HueModifierForm())
                {
                    hueModifierForm.StartPosition = FormStartPosition.CenterParent;
                    hueModifierForm.ShowDialog();
                    if (hueModifierForm.DialogResult == DialogResult.OK)
                    {
                        ImageEditor.HueModifier(pictureBox, hueModifierForm.HueValue);
                    }
                }
            }
        }

        private void rotateChannelsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ImageEditor.RotateChannels(pictureBox);
            }
        }

        private void invertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat != PixelFormat.Format8bppIndexed)
            {
                ImageEditor.Invert(pictureBox);
            }
        }

        private void imageEdgeDetectorsHomogenity_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat == PixelFormat.Format8bppIndexed)  //The filter accepts 8 bpp grayscale images for processing
            {
                ImageEditor.HomogenityEdgeDetector(pictureBox);
            }
        }

        private void differenceEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat == PixelFormat.Format8bppIndexed)  //The filter accepts 8 bpp grayscale images for processing
            {
                ImageEditor.DifferenceEdgeDetector(pictureBox);
            }
        }

        private void sobelEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat == PixelFormat.Format8bppIndexed)  //The filter accepts 8 bpp grayscale images for processing
            {
                ImageEditor.SobelEdgeDetector(pictureBox);
            }
        }

        private void cannyEdgeDetectorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null && pictureBox.Image.PixelFormat == PixelFormat.Format8bppIndexed)  //The filter accepts 8 bpp grayscale images for processing
            {
                ImageEditor.CannyEdgeDetector(pictureBox);
            }
        }
    }
}