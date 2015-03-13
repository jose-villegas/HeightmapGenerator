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
            Heightmap heightmap = Heightmap.Instance;
            heightmap.SetDimensions((int)mapWidth.Value, (int)mapHeight.Value);
            heightmap.PerlinNoiseThreaded((int)octaves.Value, (double)persistence.Value, (double)frequency.Value,
                                          (double)amplitude.Value);
            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }
    }
}
