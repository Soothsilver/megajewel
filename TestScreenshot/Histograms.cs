using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Megajewel
{
    [Serializable]
    public class Histograms
    {
        public Histogram Red = new Histogram();
        public Histogram Green = new Histogram();
        public Histogram Blue = new Histogram();
        public List<Histogram> AllHistograms;
        public Histograms()
        {
            Red.Buckets = new int[Histogram.BucketCount];
            Green.Buckets = new int[Histogram.BucketCount];
            Blue.Buckets = new int[Histogram.BucketCount];
            AllHistograms = new List<Histogram>() { Red, Green, Blue };
        }

        internal unsafe static Histograms Calculate(Bitmap bitmap)
        {
            Bitmap b = bitmap;
            BitmapData bData = b.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            Histograms histograms = new Histograms();
            byte bitsPerPixel = (byte)Image.GetPixelFormatSize(b.PixelFormat);

            /*This time we convert the IntPtr to a ptr*/
            byte* scan0 = (byte*)bData.Scan0.ToPointer();

            for (int i = 0; i < bData.Height; ++i)
            {
                for (int j = 0; j < bData.Width; ++j)
                {
                    // Ignore borders.
                    if (i < 40 || j < 40 || i >= 112 - 40 || j >= 112 - 40) continue;

                    byte* data = scan0 + i * bData.Stride + j * bitsPerPixel / 8;

                    byte blue = *data;
                    byte green = *(data + 1);
                    byte red = *(data + 2);
                    
                    histograms.Red.Buckets[red / Histogram.BucketSize]++;
                    histograms.Green.Buckets[green / Histogram.BucketSize]++;
                    histograms.Blue.Buckets[blue / Histogram.BucketSize]++;

                    //data is a pointer to the first byte of the 3-byte color data
                }
            }

            b.UnlockBits(bData);

            return histograms;
        }

        internal unsafe static Color GetAverageColor(Bitmap cleared)
        {
            Bitmap b = cleared;
            BitmapData bData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, b.PixelFormat);
            
            byte bitsPerPixel = (byte)Image.GetPixelFormatSize(b.PixelFormat);

            int r = 0;
            int g = 0;
            int bb = 0;
            int pixels = 0;

            /*This time we convert the IntPtr to a ptr*/
            byte* scan0 = (byte*)bData.Scan0.ToPointer();

            for (int i = 0; i < bData.Height; ++i)
            {
                for (int j = 0; j < bData.Width; ++j)
                {
                    byte* data = scan0 + i * bData.Stride + j * bitsPerPixel / 8;

                    byte blue = *data;
                    byte green = *(data + 1);
                    byte red = *(data + 2);

                    r += red;
                    g += green;
                    bb += blue;
                    pixels++;

                    //data is a pointer to the first byte of the 3-byte color data
                }
            }

            b.UnlockBits(bData);

            return Color.FromArgb(r / pixels, g / pixels, bb / pixels);
        }

        internal static int GetDistance(Histograms histograms1, Histograms histograms2)
        {
            int distance = 0;
            for(int i = 0; i < 2; i++)
            {
                for (int j = 0; j < Histogram.BucketCount; j++)
                {
                    distance += Math.Abs(histograms1.AllHistograms[i].Buckets[j] - histograms2.AllHistograms[i].Buckets[j]);
                }
            }
            return distance;
        }
    }
    [Serializable]
    public struct Histogram
    {
        public const int BucketCount = 5;
        public const int BucketSize = 52;
        public int[] Buckets;
    }
}