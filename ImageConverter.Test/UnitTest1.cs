using Microsoft.VisualStudio.TestTools.UnitTesting;
using Gatosyocora.ImageConverter;
using System;
using System.IO;

namespace Gatosyocora.ImageConverter.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestArgumentNullCheck()
        {
            try
            {
                ImageConverterLogic.FlipHorizontal(null);
            }
            catch (NullReferenceException)
            {
                return;
            }

            Assert.Fail("ExceptionÇ™î≠ê∂ÇµÇ»Ç©Ç¡ÇΩ");
        }

        [TestMethod]
        public void TestArgumentNoExistFilePathCheck()
        {
            try
            {
                ImageConverterLogic.FlipHorizontal(@"C:\hogehoge.png");
            }
            catch (FileNotFoundException)
            {
                return;
            }

            Assert.Fail("ExceptionÇ™î≠ê∂ÇµÇ»Ç©Ç¡ÇΩ");
        }
    }
}
