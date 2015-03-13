namespace HeightmapGenerator
{
    partial class mainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.heightmapPanel = new System.Windows.Forms.Panel();
            this.heightmapPicture = new System.Windows.Forms.PictureBox();
            this.generatorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveHeightmapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlinNoiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.erodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianBlurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.heightmapPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightmapPicture)).BeginInit();
            this.generatorMenuStrip.SuspendLayout();
            this.SuspendLayout();
            //
            // heightmapPanel
            //
            this.heightmapPanel.AutoScroll = true;
            this.heightmapPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.heightmapPanel.Controls.Add(this.heightmapPicture);
            this.heightmapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heightmapPanel.Location = new System.Drawing.Point(0, 24);
            this.heightmapPanel.Name = "heightmapPanel";
            this.heightmapPanel.Size = new System.Drawing.Size(970, 669);
            this.heightmapPanel.TabIndex = 5;
            this.heightmapPanel.SizeChanged += new System.EventHandler(this.heightmapPicture_SizeChanged);
            //
            // heightmapPicture
            //
            this.heightmapPicture.BackColor = System.Drawing.Color.White;
            this.heightmapPicture.Location = new System.Drawing.Point(101, 60);
            this.heightmapPicture.Name = "heightmapPicture";
            this.heightmapPicture.Size = new System.Drawing.Size(300, 300);
            this.heightmapPicture.TabIndex = 0;
            this.heightmapPicture.TabStop = false;
            this.heightmapPicture.SizeChanged += new System.EventHandler(this.heightmapPicture_SizeChanged);
            //
            // generatorMenuStrip
            //
            this.generatorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.fileToolStripMenuItem,
                this.editToolStripMenuItem
            });
            this.generatorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.generatorMenuStrip.Name = "generatorMenuStrip";
            this.generatorMenuStrip.Size = new System.Drawing.Size(970, 24);
            this.generatorMenuStrip.TabIndex = 6;
            this.generatorMenuStrip.Text = "menuStrip1";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.saveHeightmapToolStripMenuItem
            });
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            //
            // saveHeightmapToolStripMenuItem
            //
            this.saveHeightmapToolStripMenuItem.Name = "saveHeightmapToolStripMenuItem";
            this.saveHeightmapToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveHeightmapToolStripMenuItem.Text = "Save Heightmap";
            this.saveHeightmapToolStripMenuItem.Click += new System.EventHandler(this.saveHeightmap_Click);
            //
            // editToolStripMenuItem
            //
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.perlinNoiseToolStripMenuItem,
                this.erodeToolStripMenuItem,
                this.gaussianBlurToolStripMenuItem
            });
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            //
            // perlinNoiseToolStripMenuItem
            //
            this.perlinNoiseToolStripMenuItem.Name = "perlinNoiseToolStripMenuItem";
            this.perlinNoiseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.perlinNoiseToolStripMenuItem.Text = "Perlin Noise";
            this.perlinNoiseToolStripMenuItem.Click += new System.EventHandler(this.perlinNoiseToolStripMenuItem_Click);
            //
            // erodeToolStripMenuItem
            //
            this.erodeToolStripMenuItem.Name = "erodeToolStripMenuItem";
            this.erodeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.erodeToolStripMenuItem.Text = "Erode";
            this.erodeToolStripMenuItem.Click += new System.EventHandler(this.erodeToolStripMenuItem_Click);
            //
            // gaussianBlurToolStripMenuItem
            //
            this.gaussianBlurToolStripMenuItem.Name = "gaussianBlurToolStripMenuItem";
            this.gaussianBlurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gaussianBlurToolStripMenuItem.Text = "Gaussian Blur";
            this.gaussianBlurToolStripMenuItem.Click += new System.EventHandler(this.gaussianBlurToolStripMenuItem_Click);
            //
            // mainWindow
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 693);
            this.Controls.Add(this.heightmapPanel);
            this.Controls.Add(this.generatorMenuStrip);
            this.MainMenuStrip = this.generatorMenuStrip;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "mainWindow";
            this.Text = "Heightmap Generator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.heightmapPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.heightmapPicture)).EndInit();
            this.generatorMenuStrip.ResumeLayout(false);
            this.generatorMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.Panel heightmapPanel;
        private System.Windows.Forms.PictureBox heightmapPicture;
        private System.Windows.Forms.MenuStrip generatorMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveHeightmapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem perlinNoiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem erodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianBlurToolStripMenuItem;

    }
}

