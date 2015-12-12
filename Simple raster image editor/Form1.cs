﻿using System;
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
            Bitmap bm = new Bitmap(962, 515);
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
            pictureBox.Location = new Point((pictureBox.Parent.ClientSize.Width / 2) - (pictureBox.Image.Width / 2),
                                        (pictureBox.Parent.ClientSize.Height / 2) - (pictureBox.Image.Height / 2));
            pictureBox.Refresh();
        }

        private void buttonPencil_Click(object sender, EventArgs e)
        {
            currItem = Item.Pencil;
            _pen = new Pen(_color, 2);
            _pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }

        private void buttonRubber_Click(object sender, EventArgs e)
        {
            currItem = Item.Rubber;
            _pen = new Pen(Color.White, 10);
            _pen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
        }


        private void buttonLine_Click(object sender, EventArgs e)
        {
            currItem = Item.Line;
            _pen = new Pen(_color, 3);
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            currItem = Item.Rectangle;
            _pen = new Pen(_color, 3);
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            currItem = Item.Ellipse;
            _pen = new Pen(_color, 3);
        }

        private void buttonColorDialog_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            _color = colorDialog.Color;
            textBoxColor.BackColor = _color;
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
            }
            _previous = null;
        }

        private void menuImageRecolorGrayscale_Click(object sender, EventArgs e)
        {
            ImageEditor.ConvertToGrayscale(pictureBox);
        }
    }
}
