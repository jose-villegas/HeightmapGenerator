using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.IO;

namespace HeightmapGenerator
{

    public partial class DiffusionLimitedAgregationEditor : Form
    {
        public PictureBox heightmapPicture;

        public DiffusionLimitedAgregationEditor()
        {
            InitializeComponent();
            this.seedVal.Maximum = int.MaxValue;
            this.seedVal.Minimum = int.MinValue;
            this.Height -= this.groupBox3.Height;
        }

        private void enableSeed_CheckedChanged(object sender, EventArgs e)
        {
            this.seedVal.Enabled = enableSeed.Checked;
        }

        private void gaussianEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.copyCount.Enabled = this.gaussianEnable.Checked;
            this.groupBox1.Enabled = this.gaussianEnable.Checked;
        }

        private void generateHeightmap_Click(object sender, EventArgs e)
        {
            Heightmap heightmap = Heightmap.Instance;
            heightmap.SetDimensions((int)mapWidth.Value, (int)mapHeight.Value);
            int seed;

            if(this.enableSeed.Checked)
            {
                seed = (int)seedVal.Value;
            }
            else
            {
                seed = (new Random()).Next();
                seedVal.Value = (Decimal)seed;
            }

            heightmap.DiffusionLimitedAgregation(seed, (float)(this.occupation.Value / this.occupation.Maximum),
                                                 (int)this.frequency.Value);

            // apply gaussian pass, multiple kernel sizes sum and normalize
            if(gaussianEnable.Checked)
            {
                List<Bitmap> dlaCopies = new List<Bitmap>();
                Bitmap dilatedBitmap = (Bitmap)heightmap.Texture.Clone();
                AForge.Imaging.Filters.GaussianBlur gaussian = new AForge.Imaging.Filters.GaussianBlur(4.0, 21);
                AForge.Imaging.Filters.Dilatation dilatationFilter = new AForge.Imaging.Filters.Dilatation();
                GaussianBlur gaus = new GaussianBlur(2);

                for(int i = 0; i < (int)copyCount.Value; i++)
                {
                    // apply filter, first increasinly dilate the picture
                    dilatedBitmap = dilatationFilter.Apply(dilatedBitmap);
                    // then apply gaussian blur with an increasing radius size
                    Bitmap blurredBitmap = (Bitmap)dilatedBitmap.Clone();

                    if(radialBlur.Checked)
                    {
                        for(int j = 0; j < (i * 3) + 1; j++)
                        {
                            blurredBitmap = gaussian.Apply(blurredBitmap);
                        }
                    }
                    else
                    {
                        gaus.Radius = (int)Math.Pow(2, i + 1);
                        blurredBitmap = gaus.ProcessImage(blurredBitmap);
                    }

                    dlaCopies.Add(blurredBitmap);
                }

                // add noise to final texture collections
                if(noiseEnabled.Checked) dlaCopies.Add(NoiseTexture((int)perlinOctaves.Value, (double)perlinPersistence.Value,
                                                           (double)perlinFreq.Value, (double)perlinAmplitude.Value));

                // normalize all blurred heightmaps
                Bitmap bmp = (Bitmap)heightmap.Texture.Clone();
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
                byte[] finalData = new byte[bmpData.Height * bmpData.Stride];

                // sum average between all blurred pictures
                for(int i = 0; i < dlaCopies.Count; i++)
                {
                    // AForge.Imaging.Filters addFilter = new AForge.Imaging.Filters.Add(blurredBitmap);
                    Bitmap current = dlaCopies[i];
                    BitmapData currentData = current.LockBits(new Rectangle(0, 0, current.Width, current.Height), ImageLockMode.ReadOnly,
                                             current.PixelFormat);
                    byte[] currentRawData = new byte[currentData.Height * currentData.Stride];
                    Marshal.Copy(currentData.Scan0, currentRawData, 0, currentData.Height * currentData.Stride);
                    // lamba operation sums averages between blurred pictures
                    Parallel.For(0, currentRawData.Length, index =>
                    {
                        finalData[index] = (byte)(currentRawData[index] * 1.0f / (float)dlaCopies.Count + finalData[index]);
                    });
                }

                // save final raw pixel data
                Marshal.Copy(finalData, 0, bmpData.Scan0, finalData.Length);
                bmp.UnlockBits(bmpData);
                // store final values on heightmap
                heightmap.MapValues = finalData;
                heightmap.Texture = bmp;
            }

            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }

        private Bitmap NoiseTexture(int octaves, double persistence, double initFrequency, double initAmplitude)
        {
            Bitmap finalNoise = new Bitmap(Heightmap.Instance.Width, Heightmap.Instance.Height, PixelFormat.Format24bppRgb);
            BitmapData finalDataNoise = finalNoise.LockBits(new Rectangle(0, 0, finalNoise.Width, finalNoise.Height),
                                        ImageLockMode.WriteOnly, finalNoise.PixelFormat);
            byte[] finalRawData = new byte[finalDataNoise.Height * finalDataNoise.Stride];
            Marshal.Copy(finalDataNoise.Scan0, finalRawData, 0, finalDataNoise.Height * finalDataNoise.Stride);
            // write noise
            AForge.Math.PerlinNoise noise = new AForge.Math.PerlinNoise(octaves, persistence, initFrequency, initAmplitude);
            int height = finalDataNoise.Height, width = finalDataNoise.Width, stride = finalDataNoise.Stride;
            Parallel.For(0, height, i =>
            {
                for(int j = 0; j < width; j++)
                {
                    var value = (byte)(Math.Max(0.0f, Math.Min(1.0f, (float)noise.Function2D(i, j) * 0.5f + 0.5f)) * 255);
                    value = (byte)((value < 0) ? 0 : (value > 255) ? 255 : value);
                    finalRawData[i * stride + j * 3] = value;
                    finalRawData[i * stride + j * 3 + 1] = value;
                    finalRawData[i * stride + j * 3 + 2] = value;
                }
            });
            Marshal.Copy(finalRawData, 0, finalDataNoise.Scan0, finalRawData.Length);
            finalNoise.UnlockBits(finalDataNoise);
            return finalNoise;
        }

        private void noiseEnabled_CheckedChanged(object sender, EventArgs e)
        {
            this.groupBox3.Visible = this.groupBox3.Enabled = this.noiseEnabled.Checked;

            if(this.noiseEnabled.Checked)
            {
                this.Size = new Size(254, 405);
            }
            else
            {
                this.Size = new Size(254, 405 - this.groupBox3.Height);
            }
        }
    }
}
