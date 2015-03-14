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

namespace HeightmapGenerator
{
    public partial class DiffusionLimitedAgregationEditor : Form
    {
        public PictureBox heightmapPicture;

        public DiffusionLimitedAgregationEditor()
        {
            InitializeComponent();
            this.seedVal.Enabled = this.copyCount.Enabled = false;
            this.seedVal.Maximum = int.MaxValue;
            this.seedVal.Minimum = int.MinValue;
        }

        private void enableSeed_CheckedChanged(object sender, EventArgs e)
        {
            this.seedVal.Enabled = enableSeed.Checked;
        }

        private void gaussianEnable_CheckedChanged(object sender, EventArgs e)
        {
            this.copyCount.Enabled = this.gaussianEnable.Checked;
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
                AForge.Imaging.Filters.BinaryDilatation3x3 dilatationFilter = new AForge.Imaging.Filters.BinaryDilatation3x3();

                for(int i = 0; i < (int)copyCount.Value; i++)
                {
                    // apply filter, first increasinly dilate the picture
                    dilatedBitmap = dilatationFilter.Apply(dilatedBitmap);
                    // then apply gaussian blur with an increasing radius size
                    Bitmap blurredBitmap = (Bitmap)dilatedBitmap.Clone();

                    for(int j = 0; j < (i * 3) + 1; j++)
                    {
                        blurredBitmap = gaussian.Apply(blurredBitmap);
                    }

                    dlaCopies.Add(blurredBitmap);
                }

                Bitmap bmp = heightmap.Texture;
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
                byte[] finalData = new byte[bmpData.Height * bmpData.Stride];

                // sum average between all blurred pictures
                for(int i = 0; i < (int)copyCount.Value; i++)
                {
                    // AForge.Imaging.Filters addFilter = new AForge.Imaging.Filters.Add(blurredBitmap);
                    Bitmap current = dlaCopies[i];
                    BitmapData currentData = current.LockBits(new Rectangle(0, 0, current.Width, current.Height), ImageLockMode.ReadOnly,
                                             current.PixelFormat);
                    byte[] currentRawData = new byte[currentData.Height * currentData.Stride];
                    Marshal.Copy(currentData.Scan0, currentRawData, 0, currentData.Height * currentData.Stride);
                    // lamba operation sums averages between blurred pictures
                    finalData = currentRawData.Select((t, index) => (byte)
                                                      (
                                                          t * 1.0f / (float)copyCount.Value + finalData[index]
                                                      )).ToArray();
                }

                // save final raw pixel data
                Marshal.Copy(finalData, 0, bmpData.Scan0, finalData.Length);
                bmp.UnlockBits(bmpData);
                heightmap.Texture = bmp;
                // heightmap.Texture = dlaCopies.Last();
            }

            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }
    }
}
