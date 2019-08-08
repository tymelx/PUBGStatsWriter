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
            try
            {
                using (var engine = new TesseractEngine("tessdata", "eng", EngineMode.TesseractAndCube))
                {
                    using (var bitmap = SetGrayscale(RemoveNoise(new Bitmap(imageSource))))
                    {
                        engine.DefaultPageSegMode = PageSegMode.SparseText;

                        using (var page = engine.Process(bitmap))
                        {
                            return page.GetText();
                        }
                    }
                }
            }
            catch(Exception)
            {

            }

            return String.Empty;
        }


        //SetGrayscale
        public static Bitmap SetGrayscale(Bitmap img)
        {
            Bitmap temp = (Bitmap)img;
            Bitmap bmap = (Bitmap)temp.Clone();
            Color c;
            for (int i = 0; i < bmap.Width; i++)
            {
                for (int j = 0; j < bmap.Height; j++)
                {
                    c = bmap.GetPixel(i, j);
                    byte gray = (byte)(.299 * c.R + .587 * c.G + .114 * c.B);

                    bmap.SetPixel(i, j, Color.FromArgb(gray, gray, gray));
                }
            }
            return (Bitmap)bmap.Clone();
        }

        //RemoveNoise
        public static Bitmap RemoveNoise(Bitmap bmap)
        {
            for (var x = 0; x < bmap.Width; x++)
            {
                for (var y = 0; y < bmap.Height; y++)
                {
                    var pixel = bmap.GetPixel(x, y);
                    if (pixel.R < 162 && pixel.G < 162 && pixel.B < 162)
                        bmap.SetPixel(x, y, Color.Black);
                    else if (pixel.R > 162 && pixel.G > 162 && pixel.B > 162)
                        bmap.SetPixel(x, y, Color.White);
                }
            }

            return bmap;
        }
    }
}
