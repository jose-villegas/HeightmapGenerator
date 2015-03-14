using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeightmapGenerator
{
    public partial class ImprovedPerlinEditor : Form
    {
        public PictureBox heightmapPicture;

        public ImprovedPerlinEditor()
        {
            InitializeComponent();
            // set max and min for seedval
            this.seedVal.Enabled = false;
            this.seedVal.Maximum = int.MaxValue;
            this.seedVal.Minimum = int.MinValue;
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
            heightmap.ImprovedPerlinNoise((float)this.frequency.Value, seed);
            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }

        private void enableSeed_CheckedChanged(object sender, EventArgs e)
        {
            this.seedVal.Enabled = enableSeed.Checked;
        }
    }
}

