namespace HeightmapGenerator
{
    partial class DiffusionLimitedAgregationEditor
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.generateHeightmap = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radialBlur = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.gaussianEnable = new System.Windows.Forms.CheckBox();
            this.copyCount = new System.Windows.Forms.NumericUpDown();
            this.frequency = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.mapHeight = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mapWidth = new System.Windows.Forms.NumericUpDown();
            this.enableSeed = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.seedVal = new System.Windows.Forms.NumericUpDown();
            this.occupation = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupation)).BeginInit();
            this.SuspendLayout();
            //
            // groupBox2
            //
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.tableLayoutPanel2);
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 252);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parameters";
            //
            // tableLayoutPanel2
            //
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,
                                                    100F));
            this.tableLayoutPanel2.Controls.Add(this.generateHeightmap, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 172);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(254, 77);
            this.tableLayoutPanel2.TabIndex = 5;
            //
            // generateHeightmap
            //
            this.generateHeightmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.generateHeightmap.Location = new System.Drawing.Point(3, 51);
            this.generateHeightmap.Name = "generateHeightmap";
            this.generateHeightmap.Size = new System.Drawing.Size(248, 23);
            this.generateHeightmap.TabIndex = 2;
            this.generateHeightmap.Text = "Generate Heightmap";
            this.generateHeightmap.UseVisualStyleBackColor = true;
            this.generateHeightmap.Click += new System.EventHandler(this.generateHeightmap_Click);
            //
            // groupBox1
            //
            this.groupBox1.Controls.Add(this.radialBlur);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 42);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blur Type";
            //
            // radialBlur
            //
            this.radialBlur.AutoSize = true;
            this.radialBlur.Checked = true;
            this.radialBlur.Dock = System.Windows.Forms.DockStyle.Right;
            this.radialBlur.Location = new System.Drawing.Point(190, 16);
            this.radialBlur.Name = "radialBlur";
            this.radialBlur.Size = new System.Drawing.Size(55, 23);
            this.radialBlur.TabIndex = 0;
            this.radialBlur.TabStop = true;
            this.radialBlur.Text = "Radial";
            this.radialBlur.UseVisualStyleBackColor = true;
            //
            // radioButton2
            //
            this.radioButton2.AutoSize = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.Location = new System.Drawing.Point(3, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(69, 23);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Gaussian";
            this.radioButton2.UseVisualStyleBackColor = true;
            //
            // tableLayoutPanel5
            //
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute,
                                                    108F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent,
                                                    100F));
            this.tableLayoutPanel5.Controls.Add(this.gaussianEnable, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.copyCount, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.frequency, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.mapHeight, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.label11, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.mapWidth, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.enableSeed, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.seedVal, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.occupation, 1, 3);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(254, 156);
            this.tableLayoutPanel5.TabIndex = 0;
            //
            // gaussianEnable
            //
            this.gaussianEnable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gaussianEnable.AutoSize = true;
            this.gaussianEnable.Location = new System.Drawing.Point(19, 134);
            this.gaussianEnable.Name = "gaussianEnable";
            this.gaussianEnable.Size = new System.Drawing.Size(70, 17);
            this.gaussianEnable.TabIndex = 15;
            this.gaussianEnable.Text = "Blur Pass";
            this.gaussianEnable.UseVisualStyleBackColor = true;
            this.gaussianEnable.CheckedChanged += new System.EventHandler(this.gaussianEnable_CheckedChanged);
            //
            // copyCount
            //
            this.copyCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.copyCount.Enabled = false;
            this.copyCount.Location = new System.Drawing.Point(111, 133);
            this.copyCount.Maximum = new decimal(new int[]
            {
                16,
                0,
                0,
                0
            });
            this.copyCount.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.copyCount.Name = "copyCount";
            this.copyCount.Size = new System.Drawing.Size(140, 20);
            this.copyCount.TabIndex = 16;
            this.copyCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.copyCount.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            //
            // frequency
            //
            this.frequency.Dock = System.Windows.Forms.DockStyle.Top;
            this.frequency.Location = new System.Drawing.Point(111, 55);
            this.frequency.Maximum = new decimal(new int[]
            {
                32,
                0,
                0,
                0
            });
            this.frequency.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });
            this.frequency.Name = "frequency";
            this.frequency.Size = new System.Drawing.Size(140, 20);
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
            this.label8.Location = new System.Drawing.Point(22, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Node Count";
            //
            // mapHeight
            //
            this.mapHeight.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapHeight.Location = new System.Drawing.Point(111, 29);
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
            this.mapHeight.Size = new System.Drawing.Size(140, 20);
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
            this.label11.Location = new System.Drawing.Point(35, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Height";
            //
            // label12
            //
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Width";
            //
            // mapWidth
            //
            this.mapWidth.Dock = System.Windows.Forms.DockStyle.Top;
            this.mapWidth.Location = new System.Drawing.Point(111, 3);
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
            this.mapWidth.Size = new System.Drawing.Size(140, 20);
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
            // enableSeed
            //
            this.enableSeed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enableSeed.AutoSize = true;
            this.enableSeed.Location = new System.Drawing.Point(28, 108);
            this.enableSeed.Name = "enableSeed";
            this.enableSeed.Size = new System.Drawing.Size(51, 17);
            this.enableSeed.TabIndex = 12;
            this.enableSeed.Text = "Seed";
            this.enableSeed.UseVisualStyleBackColor = true;
            this.enableSeed.CheckedChanged += new System.EventHandler(this.enableSeed_CheckedChanged);
            //
            // label1
            //
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Min % Occupation";
            //
            // seedVal
            //
            this.seedVal.Dock = System.Windows.Forms.DockStyle.Top;
            this.seedVal.Enabled = false;
            this.seedVal.Location = new System.Drawing.Point(111, 107);
            this.seedVal.Name = "seedVal";
            this.seedVal.Size = new System.Drawing.Size(140, 20);
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
            // occupation
            //
            this.occupation.DecimalPlaces = 2;
            this.occupation.Dock = System.Windows.Forms.DockStyle.Top;
            this.occupation.Location = new System.Drawing.Point(111, 81);
            this.occupation.Name = "occupation";
            this.occupation.Size = new System.Drawing.Size(140, 20);
            this.occupation.TabIndex = 14;
            this.occupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.occupation.Value = new decimal(new int[]
            {
                1500,
                0,
                0,
                131072
            });
            //
            // DiffusionLimitedAgregationEditor
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 250);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DiffusionLimitedAgregationEditor";
            this.Text = "Diffusion Limited Agregation";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seedVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.occupation)).EndInit();
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
        private System.Windows.Forms.CheckBox enableSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown occupation;
        private System.Windows.Forms.CheckBox gaussianEnable;
        private System.Windows.Forms.NumericUpDown copyCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button generateHeightmap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radialBlur;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}