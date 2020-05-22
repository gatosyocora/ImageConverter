using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Gatosyocora.ImageConverter.Logic;

namespace Gatosyocora.ImageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args?.Length > 0 && string.IsNullOrEmpty(args[0])) return;

            ImageConverterLogic.FlipHorizontal(args[0]);
        }
    }
}
