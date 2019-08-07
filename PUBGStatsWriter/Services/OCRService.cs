using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace PUBGStatsWriter.Services
{
    public static class OCRService
    {
        public static string GetImageWords(string imageSource)
        {
            List<string> foundWords = new List<string>();

            var Ocr = new IronOcr.AdvancedOcr()
            {
                CleanBackgroundNoise = false,
                EnhanceContrast = true,
                EnhanceResolution = false,
                Language = IronOcr.Languages.English.OcrLanguagePack,
                Strategy = IronOcr.AdvancedOcr.OcrStrategy.Fast,
                ColorSpace = IronOcr.AdvancedOcr.OcrColorSpace.Color,
                DetectWhiteTextOnDarkBackgrounds = true,
                InputImageType = IronOcr.AdvancedOcr.InputTypes.Snippet,
                RotateAndStraighten = false,
                ReadBarCodes = false,
                ColorDepth = 20
            };

            var result = Ocr.Read(imageSource);
            return result.Text;
        }
    }
}
