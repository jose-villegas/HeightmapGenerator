namespace HeightmapGenerator
{
    partial class ImprovedPerlinEditor
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.mapHeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mapWidth = new System.Windows.Forms.NumericUpDown();
            this.seedVal = new System.Windows.Forms.NumericUpDown();
            this.enableSeed = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.generateHeightmap = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedVal)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            //
            // groupBox2
            //
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            //
            // tableLayoutPanel5
            //
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute,
                                                    75F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,
                                                    100F));
            this.tableLayoutPanel5.Controls.Add(this.frequency, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.mapHeight, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.mapWidth, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.seedVal, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.enableSeed, 0, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(234, 104);
            this.tableLayoutPanel5.TabIndex = 0;
            //
            // frequency
            //
            this.frequency.DecimalPlaces = 5;
            this.frequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.frequency.Increment = new decimal(new int[]
            {
                5,
                0,
                0,
                65536
            });
            this.frequency.Location = new System.Drawing.Point(78, 55);
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(153, 20);
            this.frequency.TabIndex = 9;
            this.frequency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.frequency.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            //
            // label8
            //
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Frequency";
            //
            // mapHeight
            //
            this.mapHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapHeight.Location = new System.Drawing.Point(78, 29);
            this.mapHeight.Maximum = new decimal(new int[]
            {
                16384,
                0,
                0,
                0
            });
            this.mapHeight.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.mapHeight.Name = "mapHeight";
            this.mapHeight.Size = new System.Drawing.Size(153, 20);
            this.mapHeight.TabIndex = 3;
            this.mapHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mapHeight.Value = new decimal(new int[]
            {
                300,
                0,
                0,
                0
            });
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
            this.mapWidth.Maximum = new decimal(new int[]
            {
                16384,
                0,
                0,
                0
            });
            this.mapWidth.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.mapWidth.Name = "mapWidth";
            this.mapWidth.Size = new System.Drawing.Size(153, 20);
            this.mapWidth.TabIndex = 1;
            this.mapWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mapWidth.Value = new decimal(new int[]
            {
                300,
                0,
                0,
                0
            });
            //
            // seedVal
            //
            this.seedVal.Dock = System.Windows.Forms.DockStyle.Top;
            this.seedVal.Location = new System.Drawing.Point(78, 81);
            this.seedVal.Name = "seedVal";
            this.seedVal.Size = new System.Drawing.Size(153, 20);
            this.seedVal.TabIndex = 11;
            this.seedVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.seedVal.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            //
            // enableSeed
            //
            this.enableSeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enableSeed.AutoSize = true;
            this.enableSeed.Location = new System.Drawing.Point(12, 82);
            this.enableSeed.Name = "enableSeed";
            this.enableSeed.Size = new System.Drawing.Size(51, 17);
            this.enableSeed.TabIndex = 12;
            this.enableSeed.Text = "Seed";
            this.enableSeed.UseVisualStyleBackColor = true;
            this.enableSeed.CheckedChanged += new System.EventHandler(this.enableSeed_CheckedChanged);
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,
                                                    100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute,
                                                    20F));
            this.tableLayoutPanel2.Controls.Add(this.generateHeightmap, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 123);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(240, 29);
            this.tableLayoutPanel2.TabIndex = 4;
            //
            // generateHeightmap
            //
            this.generateHeightmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateHeightmap.Location = new System.Drawing.Point(3, 3);
            this.generateHeightmap.Name = "generateHeightmap";
            this.generateHeightmap.Size = new System.Drawing.Size(234, 23);
            this.generateHeightmap.TabIndex = 2;
            this.generateHeightmap.Text = "Generate Heightmap";
            this.generateHeightmap.UseVisualStyleBackColor = true;
            this.generateHeightmap.Click += new System.EventHandler(this.generateHeightmap_Click);
            //
            // ImprovedPerlinEditor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 152);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ImprovedPerlinEditor";
            this.Text = "Improved Perlin Noise";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedVal)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown frequency;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown mapHeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown mapWidth;
        private System.Windows.Forms.NumericUpDown seedVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button generateHeightmap;
        private System.Windows.Forms.CheckBox enableSeed;
    }
}