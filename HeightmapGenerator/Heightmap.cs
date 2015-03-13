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
        private ColorPalette pal;
        private byte[] MapValues { get; set; }
        private bool _bitsLocked = false;
        private bool _dimensionsChanged = true;

        public AForge.Math.PerlinNoise Perlin { get; set; }

        private static Heightmap _instance = null;

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

        private Heightmap()
        {
            bmp = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
            // gray scale palette
            pal = bmp.Palette;
            for(int i = 0; i <= 255; i++)
            {
                // create greyscale color table
                pal.Entries[i] = Color.FromArgb(i, i, i);
            }
            bmp.Palette = pal; // re-set color palette
        }

        // singleton pattern
        public static Heightmap Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new Heightmap();
                }
                return _instance;
            }
        }

        public void SetDimensions(int width, int height)
        {
            if(bmp != null && (bmp.Width == width && bmp.Height == height)) { _dimensionsChanged = false; return; };
            // create bitmap and reserve memory for raw pixel data
            bmp = new Bitmap(width, height, PixelFormat.Format8bppIndexed);
            bmp.Palette = pal; // re-set color palette
            // set control for new dimensions
            _dimensionsChanged = true;
        }

        private void LockForWriting()
        {
            if(_bitsLocked) return;
            // create bitmap data and lockbits for fast writing
            bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
            _bitsLocked = true;
            // set internals
            _height = bmp.Height;
            _width = bmp.Width;
            _stride = bmpData.Stride;
        }

        private void CopyToTexture()
        {
            if(MapValues == null && _bitsLocked) return;
            // copy the data from the raw pixel array
            Marshal.Copy(MapValues, 0, bmpData.Scan0, MapValues.Length);
        }

        private void Unlock()
        {
            _bitsLocked = false;
            // unlock bits
            bmp.UnlockBits(bmpData);
        }

        public void PerlinNoise(int octaves, double persistence, double initFrequency, double initAmplitude)
        {
            LockForWriting();
            // reserve for texture values
            if(_dimensionsChanged)
            {
                MapValues = new byte[_height * _stride];
            }
            if(MapValues == null || !_bitsLocked) return;
            // perlin function
            Perlin = new AForge.Math.PerlinNoise(octaves, persistence, initFrequency, initAmplitude);
            // assign perlin noise value per pixel
            for(int i = 0; i < _height; i++)
            {
                for(int j = 0; j < _width; j++)
                {
                    var value = Math.Max(0.0f, Math.Min(1.0, (double)Perlin.Function2D(i, j) * 0.5f + 0.5f));
                    // from 0.0 - 1.0 to 0 - 255 byte data
                    value = value * 255;
                    // assign values at rgb positions
                    MapValues[i * _stride + j] = (byte)value;
                }
            }
            CopyToTexture();
            Unlock();
        }

        public void PerlinNoiseThreaded(int octaves, double persistence, double initFrequency, double initAmplitude)
        {
            LockForWriting();
            // reserve for texture values
            if(_dimensionsChanged)
            {
                MapValues = new byte[_height * _stride];
            }
            if(MapValues == null || !_bitsLocked) return;
            // thread work subdivitions
            int subDivs = (int)Math.Ceiling((double)_height / (Environment.ProcessorCount - 1));
            // perlin function
            Perlin = new AForge.Math.PerlinNoise(octaves, persistence, initFrequency, initAmplitude);
            // assign work to threads
            for(int i = 0; i < Environment.ProcessorCount - 1; i++)
            {
                int startIndex = i * subDivs;
                int endIndex = Math.Min(startIndex + subDivs, _height);
                // fire up threads
                _perlinWorker[i] = new Thread(() => CalculateSection(startIndex, endIndex));
                _perlinWorker[i].Start();
            }
            // wait for all threads to finish
            for(int i = 0; i < Environment.ProcessorCount - 1; i++)
            {
                _perlinWorker[i].Join();
            }
            CopyToTexture();
            Unlock();
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
                    MapValues[i * _stride + j] = (byte)value;
                }
            }
        }

        public void Erode()
        {
            // apply filter
            AForge.Imaging.Filters.Erosion erosion = new AForge.Imaging.Filters.Erosion();
            bmp = erosion.Apply(this.bmp);
        }

        public void GaussianBlur()
        {
            // apply filter
            AForge.Imaging.Filters.GaussianBlur gauss = new AForge.Imaging.Filters.GaussianBlur();
            bmp = gauss.Apply(this.bmp);
        }

    }
}
