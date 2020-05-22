using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Gatosyocora.ImageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length > 0 && string.IsNullOrEmpty(args[0])) return;

            FlipY(args[0]);
        }

        private static void FlipY(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return;

            Image srcImage;
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                srcImage = Image.FromStream(stream);
            }
            srcImage.RotateFlip(RotateFlipType.Rotate180FlipY);
            srcImage.Save(filePath, ImageFormat.Png);
            srcImage.Dispose();
        }
    }
}
