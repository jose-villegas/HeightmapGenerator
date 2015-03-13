namespace HeightmapGenerator
{
    partial class PerlinNoiseEditor
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.generateHeightmap = new System.Windows.Forms.Button();
            this.liveReload = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.persistence = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.octaves = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.mapHeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mapWidth = new System.Windows.Forms.NumericUpDown();
            this.amplitude = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.octaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).BeginInit();
            this.SuspendLayout();
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                                                        System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                                                        System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.generateHeightmap, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.liveReload, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 178);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(
                                                     System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(279, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            //
            // generateHeightmap
            //
            this.generateHeightmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateHeightmap.Location = new System.Drawing.Point(92, 3);
            this.generateHeightmap.Name = "generateHeightmap";
            this.generateHeightmap.Size = new System.Drawing.Size(184, 23);
            this.generateHeightmap.TabIndex = 1;
            this.generateHeightmap.Text = "Generate Heightmap";
            this.generateHeightmap.UseVisualStyleBackColor = true;
            this.generateHeightmap.Click += new System.EventHandler(
                                                this.generateHeightmap_Click);
            //
            // liveReload
            //
            this.liveReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.liveReload.AutoSize = true;
            this.liveReload.Checked = true;
            this.liveReload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.liveReload.Location = new System.Drawing.Point(3, 6);
            this.liveReload.Name = "liveReload";
            this.liveReload.Size = new System.Drawing.Size(83, 17);
            this.liveReload.TabIndex = 2;
            this.liveReload.Text = "Live Reload";
            this.liveReload.UseVisualStyleBackColor = true;
            //
            // groupBox2
            //
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 175);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            //
            // tableLayoutPanel5
            //
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                                                        System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(
                                                        System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.frequency, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.persistence, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.label9, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.octaves, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label10, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.mapHeight, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.mapWidth, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.amplitude, 1, 5);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(273, 156);
            this.tableLayoutPanel5.TabIndex = 0;
            //
            // label7
            //
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Amplitude";
            //
            // frequency
            //
            this.frequency.DecimalPlaces = 5;
            this.frequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.frequency.Increment = new decimal(new int[] {
                1,
                0,
                0,
                196608
            });
            this.frequency.Location = new System.Drawing.Point(78, 107);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(192, 20);
            this.frequency.TabIndex = 9;
            this.frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequency.Value = new decimal(new int[] {
                3125,
                0,
                0,
                327680
            });
            this.frequency.ValueChanged += new System.EventHandler(
                                               this.generateHeightmap_OnChange);
            //
            // label8
            //
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Frequency";
            //
            // persistence
            //
            this.persistence.DecimalPlaces = 5;
            this.persistence.Dock = System.Windows.Forms.DockStyle.Top;
            this.persistence.Increment = new decimal(new int[] {
                1,
                0,
                0,
                131072
            });
            this.persistence.Location = new System.Drawing.Point(78, 81);
            this.persistence.Name = "persistence";
            this.persistence.Size = new System.Drawing.Size(192, 20);
            this.persistence.TabIndex = 7;
            this.persistence.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.persistence.Value = new decimal(new int[] {
                5,
                0,
                0,
                65536
            });
            this.persistence.ValueChanged += new System.EventHandler(
                                                 this.generateHeightmap_OnChange);
            //
            // label9
            //
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Persistence";
            //
            // octaves
            //
            this.octaves.Dock = System.Windows.Forms.DockStyle.Top;
            this.octaves.Location = new System.Drawing.Point(78, 55);
            this.octaves.Minimum = new decimal(new int[] {
                1,
                0,
                0,
                0
            });
            this.octaves.Name = "octaves";
            this.octaves.Size = new System.Drawing.Size(192, 20);
            this.octaves.TabIndex = 5;
            this.octaves.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.octaves.Value = new decimal(new int[] {
                6,
                0,
                0,
                0
            });
            this.octaves.ValueChanged += new System.EventHandler(
                                             this.generateHeightmap_OnChange);
            //
            // label10
            //
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Octaves";
            //
            // mapHeight
            //
            this.mapHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapHeight.Location = new System.Drawing.Point(78, 29);
            this.mapHeight.Maximum = new decimal(new int[] {
                16384,
                0,
                0,
                0
            });
            this.mapHeight.Minimum = new decimal(new int[] {
                1,
                0,
                0,
                0
            });
            this.mapHeight.Name = "mapHeight";
            this.mapHeight.Size = new System.Drawing.Size(192, 20);
            this.mapHeight.TabIndex = 3;
            this.mapHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mapHeight.Value = new decimal(new int[] {
                300,
                0,
                0,
                0
            });
            this.mapHeight.ValueChanged += new System.EventHandler(
                                               this.generateHeightmap_OnChange);
            //
            // label11
            //
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Height";
            //
            // label12
            //
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Width";
            //
            // mapWidth
            //
            this.mapWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapWidth.Location = new System.Drawing.Point(78, 3);
            this.mapWidth.Maximum = new decimal(new int[] {
                16384,
                0,
                0,
                0
            });
            this.mapWidth.Minimum = new decimal(new int[] {
                1,
                0,
                0,
                0
            });
            this.mapWidth.Name = "mapWidth";
            this.mapWidth.Size = new System.Drawing.Size(192, 20);
            this.mapWidth.TabIndex = 1;
            this.mapWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mapWidth.Value = new decimal(new int[] {
                300,
                0,
                0,
                0
            });
            this.mapWidth.ValueChanged += new System.EventHandler(
                                              this.generateHeightmap_OnChange);
            //
            // amplitude
            //
            this.amplitude.DecimalPlaces = 5;
            this.amplitude.Dock = System.Windows.Forms.DockStyle.Top;
            this.amplitude.Increment = new decimal(new int[] {
                1,
                0,
                0,
                65536
            });
            this.amplitude.Location = new System.Drawing.Point(78, 133);
            this.amplitude.Name = "amplitude";
            this.amplitude.Size = new System.Drawing.Size(192, 20);
            this.amplitude.TabIndex = 11;
            this.amplitude.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.amplitude.Value = new decimal(new int[] {
                1,
                0,
                0,
                0
            });
            this.amplitude.ValueChanged += new System.EventHandler(
                                               this.generateHeightmap_OnChange);
            //
            // PerlinNoiseEditor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 210);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PerlinNoiseEditor";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Perlin Noise";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persistence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.octaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button generateHeightmap;
        private System.Windows.Forms.CheckBox liveReload;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown persistence;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown octaves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown mapHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown mapWidth;
        private System.Windows.Forms.NumericUpDown amplitude;
    }
}