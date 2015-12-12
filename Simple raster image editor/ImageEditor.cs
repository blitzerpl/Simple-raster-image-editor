using AForge.Imaging.Filters;
using System.Drawing;
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
    }
}
