using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.Threading;

namespace HeightmapGenerator
{
    class Heightmap
    {
        private int _height;
        private int _width;
        private int _stride;

        private Bitmap bmp;
        private BitmapData bmpData;

        public AForge.Math.PerlinNoise Perlin { get; set; }
        public byte[] MapValues { get; set; }


        static private Thread[] _perlinWorker = new Thread[Environment.ProcessorCount - 1];

        public int Height
        {
            get { return _height; }
        }

        public int Width
        {
            get { return _width; }
        }

        public int Stride
        {
            get { return _stride; }
        }

        public Bitmap Texture
        {
            get { return bmp; }
        }

        public Heightmap(int width, int height, int octaves, double persistence, double initFrequency, double initAmplitude,
                         bool threaded)
        {
            // create bitmap and reserve memory for raw pixel data
            bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            // create bitmap data and lockbits for fast writing
            bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
            // perlin function
            Perlin = new AForge.Math.PerlinNoise(octaves, persistence, initFrequency, initAmplitude);
            // set internals
            _height = height;
            _width = width;
            _stride = bmpData.Stride;
            // reserve for texture values
            MapValues = new byte[_height * _stride];
            if(threaded) { AddPerlinNoiseThreaded(); }
            else { AddPerlinNoise(); }
        }

        private void AddPerlinNoise()
        {
            for(int i = 0; i < _height; i++)
            {
                for(int j = 0; j < _width; j++)
                {
                    var value = Math.Max(0.0f, Math.Min(1.0, (double)Perlin.Function2D(i, j) * 0.5f + 0.5f));
                    // from 0.0 - 1.0 to 0 - 255 byte data
                    value = value * 255;
                    // assign values at rgb positions
                    MapValues[i * _stride + j * 3] = (byte)value;
                    MapValues[i * _stride + j * 3 + 1] = (byte)value;
                    MapValues[i * _stride + j * 3 + 2] = (byte)value;
                }
            }
            // copy the data from the raw pixel array
            Marshal.Copy(MapValues, 0, bmpData.Scan0, MapValues.Length);
            // unlock bits
            bmp.UnlockBits(bmpData);
        }

        private void AddPerlinNoiseThreaded()
        {
            int subDivs = (int)Math.Ceiling((double)_height / (Environment.ProcessorCount - 1));
            for(int i = 0; i < Environment.ProcessorCount - 1; i++)
            {
                int startIndex = i * subDivs;
                int endIndex = Math.Min(startIndex + subDivs, _height);
                // fire up threads
                _perlinWorker[i] = new Thread(() => CalculateSection(startIndex, endIndex));
                _perlinWorker[i].Start();
            }
            for(int i = 0; i < Environment.ProcessorCount - 1; i++)
            {
                _perlinWorker[i].Join();
            }
            // copy the data from the raw pixel array
            Marshal.Copy(MapValues, 0, bmpData.Scan0, MapValues.Length);
            // unlock bits
            bmp.UnlockBits(bmpData);
        }

        private void CalculateSection(int startIndex, int endIndex)
        {
            for(int i = startIndex; i < endIndex; i++)
            {
                for(int j = 0; j < _width; j++)
                {
                    var value = Math.Max(0.0f, Math.Min(1.0, (double)Perlin.Function2D(i, j) * 0.5f + 0.5f));
                    // from 0.0 - 1.0 to 0 - 255 byte data
                    value = value * 255;
                    // assign values at rgb positions
                    MapValues[i * _stride + j * 3] = (byte)value;
                    MapValues[i * _stride + j * 3 + 1] = (byte)value;
                    MapValues[i * _stride + j * 3 + 2] = (byte)value;
                }
            }
        }


    }
}
