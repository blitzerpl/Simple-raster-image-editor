using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_raster_image_editor
{
    public class ImageEditor
    {
        // LINEAR COLOR CORRECTION FILTERS
        public static void BrightnessCorrection(PictureBox pictureBox, int value)
        {
            BrightnessCorrection filter = new BrightnessCorrection(value);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void ContrastCorrection(PictureBox pictureBox, int value)
        {
            ContrastCorrection filter = new ContrastCorrection(value);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }
        
        // RE-COLORING FILTERS
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

        // RESIZE
        public static void ResizeBilinearImage(PictureBox pictureBox, int width, int height)
        {
            ResizeBilinear filter = new ResizeBilinear(width, height);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        // ROTATE
        public static void RotateBilinear(PictureBox pictureBox, double angle)
        {
            RotateBilinear filter = new RotateBilinear(angle, true);
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        // EDGE DETECTORS
        public static void HomogenityEdgeDetector(PictureBox pictureBox)
        {
            HomogenityEdgeDetector filter = new HomogenityEdgeDetector();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void DifferenceEdgeDetector(PictureBox pictureBox)
        {
            DifferenceEdgeDetector filter = new DifferenceEdgeDetector();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void SobelEdgeDetector(PictureBox pictureBox)
        {
            SobelEdgeDetector filter = new SobelEdgeDetector();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static void CannyEdgeDetector(PictureBox pictureBox)
        {
            CannyEdgeDetector filter = new CannyEdgeDetector();
            pictureBox.Image = filter.Apply((Bitmap)pictureBox.Image);
        }

        public static double RedStatistics(PictureBox pictureBox)
        {
            return new ImageStatistics((Bitmap)pictureBox.Image).Red.Mean;
        }

        public static double BlueStatistics(PictureBox pictureBox)
        {
            return new ImageStatistics((Bitmap)pictureBox.Image).Blue.Mean;
        }

        public static double GreenStatistics(PictureBox pictureBox)
        {
            return new ImageStatistics((Bitmap)pictureBox.Image).Green.Mean;
        }
    }
}
