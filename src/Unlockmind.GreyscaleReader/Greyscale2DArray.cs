using System;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace Unlockmind.GreyscaleReader
{
    public class Greyscale2DArray
    {
        private const double ScaleUnit = (double) 255 * 3 / 100;
        
        public double[,] Value { get; }
        public int Height { get; }
        public int Width { get; }

        public Greyscale2DArray (string path)
        {
            using (Image<Rgba32> image = Image.Load(path))
            {
                Height = image.Height;
                Width = image.Width;
                Value = new double[image.Width, image.Height];
                for (int i = 0; i < image.Height; i++)
                {
                    for (int j = 0; j < image.Width; j++)
                    {
                        Rgba32 rbgaPixel = image[j, i];
                        double value = (rbgaPixel.B + rbgaPixel.R + rbgaPixel.G) / ScaleUnit;
                        double inverted = Math.Abs(100 - value);
                        Value[i, j] = inverted / 100;
                    }
                }
            }
        }
    }
}