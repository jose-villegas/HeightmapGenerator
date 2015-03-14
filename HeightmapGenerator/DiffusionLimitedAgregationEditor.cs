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
            //// resulting bitmap
            Bitmap bmp = (Bitmap)heightmap.Texture.Clone();
            // apply gaussian pass, multiple kernel sizes sum and normalize
            if(gaussianEnable.Checked)
            {
                // create bitmap data and lockbits for fast writing
                BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
                // copy values from original diffuse limited, normalize the values
                byte[] finalData = heightmap.MapValues.Select(t => (byte)(t * 1.0f / (float)(copyCount.Value + 1))).ToArray();
                for(int i = 0; i < (int)copyCount.Value; i++)
                {
                    // apply filter
                    AForge.Imaging.Filters.GaussianBlur gauss = new AForge.Imaging.Filters.GaussianBlur(1.4, 5 + i);
                    Bitmap guss = gauss.Apply(heightmap.Texture);
                    // lock bits for fast operations
                    BitmapData gussData = guss.LockBits(new Rectangle(0, 0, guss.Width, guss.Height), ImageLockMode.ReadWrite,
                                                        guss.PixelFormat);
                    // copy raw pixel data
                    byte[] gussRawData = new byte[gussData.Height * gussData.Stride];
                    Marshal.Copy(gussData.Scan0, gussRawData, 0, gussData.Height * gussData.Stride);
                    // operate on pixel data
                    byte[] normalizedData = gussRawData.Select(t => (byte)(t * 1.0f / (float)(copyCount.Value + 1))).ToArray();
                    finalData = finalData.Select((x, index) => (byte)(x + normalizedData[index])).ToArray();
                    // unlock blurred bitmap
                    guss.UnlockBits(gussData);
                }
                Marshal.Copy(finalData, 0, bmpData.Scan0, finalData.Length);
                bmp.UnlockBits(bmpData);
                heightmap.Texture = bmp;
            }
            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = bmp;
        }
    }
}
