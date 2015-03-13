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
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
            // center picture box
            this.heightmapPicture.Left = (this.heightmapPanel.ClientSize.Width - this.heightmapPicture.Width) / 2;
            this.heightmapPicture.Top = (this.heightmapPanel.ClientSize.Height - this.heightmapPicture.Height) / 2;
            this.saveImageDialog.Filter =
                "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|BMP File(*.BMP)|*.BMP|JPG File(*.JPG)|*.JPG|GIF File(*.GIF)|*.GIF";
        }

        private void saveHeightmap_Click(object sender, EventArgs e)
        {
            if(this.saveImageDialog.ShowDialog() == DialogResult.OK)
            {
                if(this.heightmapPicture.Image != null)
                {
                    this.heightmapPicture.Image.Save(this.saveImageDialog.FileName);
                }
            }
        }

        private void perlinNoiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerlinNoiseEditor perlinEditor = new PerlinNoiseEditor();
            // assign picturebox for editing and show editor
            perlinEditor.heightmapPicture = this.heightmapPicture;
            perlinEditor.Show();
        }

        private void heightmapPicture_SizeChanged(object sender, EventArgs e)
        {
            this.heightmapPicture.Left = (this.heightmapPanel.ClientSize.Width - this.heightmapPicture.Width) / 2;
            this.heightmapPicture.Top = (this.heightmapPanel.ClientSize.Height - this.heightmapPicture.Height) / 2;
        }

        private void erodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.heightmapPicture.Image == null) return;
            // otherwise apply erosion to bitmap
            Heightmap.Instance.Erode();
            this.heightmapPicture.Image = Heightmap.Instance.Texture;
        }

        private void gaussianBlurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.heightmapPicture.Image == null) return;
            // otherwise apply erosion to bitmap
            Heightmap.Instance.GaussianBlur();
            this.heightmapPicture.Image = Heightmap.Instance.Texture;
        }
    }
}
