using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Gatosyocora.ImageConverter;
using System;

namespace Gatosyocora.ImageConverter
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				ImageConverterLogic.FlipHorizontal(args[0]);
			}
			catch (Exception e)
			{
				File.AppendAllText("errorlog.txt", "ErrorMessage:"+e.Message);
				File.AppendAllText("errorlog.txt", "arg:"+args[0]);
			}
        }
    }
}
