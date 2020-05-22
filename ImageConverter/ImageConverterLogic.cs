using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;

namespace Gatosyocora.ImageConverter
{
    public static class ImageConverterLogic
    {
        /// <summary>
        /// ファイルパスから画像を読み込む
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private static Image LoadImage(string filePath)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new NullReferenceException("ファイルパスが設定されていません");
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("ファイルが見つかりません");
            }

            Image srcImage;

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.ReadWrite))
            {
                srcImage = Image.FromStream(stream);
            }
            return srcImage;
        }

        /// <summary>
        /// 画像を保存する
        /// </summary>
        /// <param name="image"></param>
        /// <param name="filePath"></param>
        private static void SaveImage(Image image, string filePath)
        {
            if (image == null)
            {
                throw new NullReferenceException();
            }

            if (string.IsNullOrEmpty(filePath))
            {
                throw new Exception("ファイルパスが設定されていません");
            }

            image.Save(filePath, ImageFormat.Png);
            image.Dispose();
        }

        /// <summary>
        /// 画像を水平方向に反転させる
        /// </summary>
        /// <param name="filePath">画像のフルパス</param>
        public static void FlipHorizontal(string filePath)
        {
            var image = LoadImage(filePath);
            FlipHorizontal(image);
            SaveImage(image, filePath);
        }

        /// <summary>
        /// 画像を垂直方向に反転させる
        /// </summary>
        /// <param name="filePath">画像のフルパス</param>
        public static void FlipVertical(string filePath)
        {
            var image = LoadImage(filePath);
            FlipVertical(image);
            SaveImage(image, filePath);
        }

        /// <summary>
        /// 画像を水平方向に反転させる
        /// </summary>
        /// <param name="filePath"></param>
        private static void FlipHorizontal(Image image)
        {
            if (image == null)
            {
                throw new NullReferenceException();
            }

            image.RotateFlip(RotateFlipType.Rotate180FlipY);
        }

        /// <summary>
        /// 画像を垂直方向に反転させる
        /// </summary>
        /// <param name="filePath"></param>
        private static void FlipVertical(Image image)
        {
            if (image == null)
            {
                throw new NullReferenceException();
            }

            image.RotateFlip(RotateFlipType.Rotate180FlipX);
        }
    }
}
