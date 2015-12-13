using AForge.Imaging.Filters;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public class ImageEditor
    {
        public static void ConvertToGrayscale(PictureBox pictureBox)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void ConvertToSepia(PictureBox pictureBox)
        {
            Sepia filter = new Sepia();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void HueModifier(PictureBox pictureBox, int value)
        {
            HueModifier filter = new HueModifier(value);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void RotateChannels(PictureBox pictureBox)
        {
            RotateChannels filter = new RotateChannels();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void Invert(PictureBox pictureBox)
        {
            Invert filter = new Invert();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }
    }
}
