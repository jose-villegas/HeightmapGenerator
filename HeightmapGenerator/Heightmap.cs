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

        private BitmapData bmpData;
        private bool _bitsLocked = false;
        private bool _dimensionsChanged = true;

        public byte[] MapValues { get; set; }
        public AForge.Math.PerlinNoise Perlin { get; set; }
        public ColorPalette Palette { get; set; }
        public Bitmap Texture;

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

        public byte this[int i, int j]
        {
            get
            {
                return MapValues[i * _stride + j];
            }
            set
            {
                MapValues[i * _stride + j] = (byte)Math.Max(0, Math.Min((int)value, 255));
            }
        }

        private Heightmap()
        {
            Texture = new Bitmap(1, 1, PixelFormat.Format8bppIndexed);
            // gray scale palette
            Palette = Texture.Palette;

            for(int i = 0; i <= 255; i++)
            {
                // create greyscale color table
                Palette.Entries[i] = Color.FromArgb(i, i, i);
            }

            Texture.Palette = Palette; // re-set color palette
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
            if(Texture != null && (Texture.Width == width && Texture.Height == height)) { _dimensionsChanged = false; return; };

            // create bitmap and reserve memory for raw pixel data
            Texture = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            Texture.Palette = Palette; // re-set color palette

            // set control for new dimensions
            _height = Texture.Height;

            _width = Texture.Width;

            _dimensionsChanged = true;
        }

        private void LockForWriting()
        {
            if(_bitsLocked) return;

            // create bitmap data and lockbits for fast writing
            bmpData = Texture.LockBits(new Rectangle(0, 0, Texture.Width, Texture.Height), ImageLockMode.WriteOnly,
                                       Texture.PixelFormat);
            _bitsLocked = true;
            // set internals
            _height = Texture.Height;
            _width = Texture.Width;
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
            Texture.UnlockBits(bmpData);
        }

        public void PerlinNoise(int octaves, double persistence, double initFrequency, double initAmplitude, bool threaded)
        {
            LockForWriting();

            // reserve for texture values
            if(_dimensionsChanged)
            {
                MapValues = new byte[_height * _stride];
            }

            // not ready for writing
            if(MapValues == null || !_bitsLocked) return;

            // subdivide work betweek threads
            if(threaded)
            {
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
            }
            else
            {
                // perlin function
                Perlin = new AForge.Math.PerlinNoise(octaves, persistence, initFrequency, initAmplitude);

                // assign perlin noise value per pixel
                for(int i = 0; i < _height; i++)
                {
                    for(int j = 0; j < _width; j++)
                    {
                        var value = Math.Max(0.0f, Math.Min(1.0, (double)Perlin.Function2D((double)i, (double)j) * 0.5 + 0.5));
                        // from 0.0 - 1.0 to 0 - 255 byte data
                        value = value * 255;
                        // assign values at rgb positions
                        this[i, j] = (byte)value;
                    }
                }
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
                    var value = Math.Max(0.0f, Math.Min(1.0, (double)Perlin.Function2D((double)i, (double)j) * 0.5 + 0.5));
                    // from 0.0 - 1.0 to 0 - 255 byte data
                    value = value * 255;
                    // assign values at rgb positions
                    this[i, j] = (byte)value;
                }
            }
        }

        public void ImprovedPerlinNoise(float frequency, int seed)
        {
            LockForWriting();

            // reserve for texture values
            if(_dimensionsChanged)
            {
                MapValues = new byte[_height * _stride];
            }

            // not ready for writing
            if(MapValues == null || !_bitsLocked) return;

            // seed the perlin noise
            Random rand = new Random(seed);
            float perlinSeed = (float)rand.NextDouble();

            // assign perlin noise value per pixel
            for(int i = 0; i < _height; i++)
            {
                for(int j = 0; j < _width; j++)
                {
                    var value = Math.Max(0.0f, Math.Min(1.0, (double)SimplexNoise.Noise.Generate(frequency * i / (float)_height,
                                                        frequency * j / (float)_width, perlinSeed) * 0.5 + 0.5));
                    // from 0.0 - 1.0 to 0 - 255 byte data
                    value = value * 255;
                    // assign values at rgb positions
                    this[i, j] = (byte)value;
                }
            }

            CopyToTexture();
            Unlock();
        }

        public void Erode()
        {
            // apply filter
            AForge.Imaging.Filters.Erosion erosion = new AForge.Imaging.Filters.Erosion();
            Texture = erosion.Apply(this.Texture);
        }

        public void GaussianBlur()
        {
            // apply filter
            AForge.Imaging.Filters.GaussianBlur gauss = new AForge.Imaging.Filters.GaussianBlur();
            Texture = gauss.Apply(this.Texture);
        }

        public void Smoothen()
        {
            // apply filter
            AForge.Imaging.Filters.BilateralSmoothing smoothing = new AForge.Imaging.Filters.BilateralSmoothing();
            Texture = smoothing.Apply(this.Texture);
        }

        public void Perturb(float f, float d)
        {
            LockForWriting();

            // not ready for writing
            if(MapValues == null || !_bitsLocked) return;

            // temporal precomputed heightmap
            int u, v;
            byte[] temp = new byte[MapValues.Length];

            // assign perlin noise value per pixel
            for(int i = 0; i < _height; i++)
            {
                for(int j = 0; j < _width; j++)
                {
                    u = i + (int)(SimplexNoise.Noise.Generate(f * i / (float)_height, f * j / (float)_width, 0.0f) * d);
                    v = j + (int)(SimplexNoise.Noise.Generate(f * i / (float)_height, f * j / (float)_width, 1.0f) * d);

                    if(u < 0) u = 0;

                    if(u >= _height) u = _height - 1;

                    if(v < 0) v = 0;

                    if(v >= _width) v = _width - 1;

                    temp[i * _stride + j] = this[u, v];
                }
            }

            MapValues = temp;
            CopyToTexture();
            Unlock();
        }

        private class Node
        {
            public Node parent = null;
            public int x = 0;
            public int y = 0;

            public void Visit()
            {
                Heightmap.Instance[x, y] += 1;

                if(parent != null)
                {
                    parent.Visit();
                }
            }

            public Node() { }

            public Node(Node parent, int x, int y)
            {
                this.x = x;
                this.y = y;
                this.parent = parent;
            }
        }

        public void DiffusionLimitedAgregation(int seed, float occupationPercent = 0.15f, int numberNodes = 1)
        {
            // at least one node, percent must be a valid value
            if(numberNodes <= 0 || occupationPercent > 1.0f || occupationPercent < 0.0f)
            {
                return;
            }

            LockForWriting();
            // reset values for fractal writing values
            MapValues = new byte[_height * _stride];

            // not ready for writing
            if(MapValues == null || !_bitsLocked) return;

            // start fractal
            Random rand = new Random(seed);
            Node[,] nodes = new Node[_width, _height];

            for(int i = 0; i < numberNodes; i++)
            {
                nodes[rand.Next(_width), rand.Next(_height)] = new Node();
            }

            int total = rand.Next(_width * _height - (int)(_width * _width * occupationPercent), _width * _height);
            int x, y;

            while(total < _width * _height)
            {
                x = rand.Next(Width);
                y = rand.Next(Height);

                if(nodes[x, y] != null)
                {
                    continue;
                }

                bool hit = false;

                // random walk until hit something
                while(!hit)
                {
                    int prevX = x;
                    int prevY = y;
                    int[] newValues = { rand.Next(-1, 2), rand.Next(-1, 2) };

                    if(newValues[0] == newValues[1] && newValues[0] == 0)
                    {
                        newValues[rand.Next(2)] = rand.Next(2) == 0 ? 1 : -1;
                    }

                    x += newValues[0];
                    y += newValues[1];

                    // out of bounds
                    if(x < 0 || y < 0 || y > Height - 1 || x > Width - 1)
                    {
                        break;
                    }

                    Node n = nodes[x, y];

                    if(n != null)
                    {
                        hit = true;
                        total += 1;
                        n = new Node(n, prevX, prevY);
                        nodes[prevX, prevY] = n;
                        n.Visit();
                    }
                }
            }

            CopyToTexture();
            Unlock();
        }

    }
}
