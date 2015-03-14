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
    public partial class PerturbEditor : Form
    {
        public PictureBox heightmapPicture;

        public PerturbEditor()
        {
            InitializeComponent();
        }

        private void generateHeightmap_Click(object sender, EventArgs e)
        {
            Heightmap heightmap = Heightmap.Instance;
            heightmap.Perturb((float)this.frequency.Value, (float)this.distance.Value);
            // show height map, set up new values
            this.heightmapPicture.Height = heightmap.Height;
            this.heightmapPicture.Width = heightmap.Width;
            this.heightmapPicture.Image = heightmap.Texture;
        }
    }
}
