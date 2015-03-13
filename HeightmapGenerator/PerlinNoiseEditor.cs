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
using System.IO;

namespace HeightmapGenerator
{
    public partial class PerlinNoiseEditor : Form
    {
        public PictureBox heightmapPicture { get; set; }

        public PerlinNoiseEditor()
        {
            InitializeComponent();
        }

        private void generateHeightmap_Click(object sender, EventArgs e)
        {
            Heightmap heightmap = new Heightmap((int)mapWidth.Value, (int)mapHeight.Value, (int)octaves.Value,
                                                (double)persistence.Value, (double)frequency.Value, (double)amplitude.Value, true);
            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }

        private void generateHeightmap_OnChange(object sender, EventArgs e)
        {
            if(this.liveReload.Checked)
            {
                generateHeightmap_Click(sender, e);
            }
        }
    }
}
