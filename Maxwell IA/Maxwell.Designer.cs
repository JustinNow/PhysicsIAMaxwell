namespace Maxwell_IA
{
    partial class Maxwell
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
            if (disposing && (components != null))
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maxwell));
            this.aopn = new System.Windows.Forms.NumericUpDown();
            this.aopl = new System.Windows.Forms.Label();
            this.templ = new System.Windows.Forms.Label();
            this.tempn = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.AvgVelt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startMaxwell = new System.Windows.Forms.Button();
            this.allText = new System.Windows.Forms.ListView();
            this.calc = new System.Windows.Forms.Button();
            this.debug = new System.Windows.Forms.Label();
            this.maxVelt = new System.Windows.Forms.TextBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aopn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // aopn
            // 
            this.aopn.AccessibleName = "aopn";
            this.aopn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.aopn.Cursor = System.Windows.Forms.Cursors.Default;
            this.aopn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.aopn.Location = new System.Drawing.Point(116, 12);
            this.aopn.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.aopn.Name = "aopn";
            this.aopn.Size = new System.Drawing.Size(92, 20);
            this.aopn.TabIndex = 0;
            this.aopn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.aopn.ValueChanged += new System.EventHandler(this.aopn_ValueChanged);
            // 
            // aopl
            // 
            this.aopl.AutoSize = true;
            this.aopl.Location = new System.Drawing.Point(12, 14);
            this.aopl.Name = "aopl";
            this.aopl.Size = new System.Drawing.Size(98, 13);
            this.aopl.TabIndex = 1;
            this.aopl.Text = "Amount of Particles";
            this.aopl.Click += new System.EventHandler(this.label1_Click);
            // 
            // templ
            // 
            this.templ.AutoSize = true;
            this.templ.Location = new System.Drawing.Point(214, 14);
            this.templ.Name = "templ";
            this.templ.Size = new System.Drawing.Size(67, 13);
            this.templ.TabIndex = 2;
            this.templ.Text = "Temperature";
            this.templ.Click += new System.EventHandler(this.label2_Click);
            // 
            // tempn
            // 
            this.tempn.Location = new System.Drawing.Point(287, 12);
            this.tempn.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tempn.Name = "tempn";
            this.tempn.Size = new System.Drawing.Size(92, 20);
            this.tempn.TabIndex = 3;
            this.tempn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tempn.ValueChanged += new System.EventHandler(this.temp_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max Velocity";
            // 
            // AvgVelt
            // 
            this.AvgVelt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AvgVelt.Location = new System.Drawing.Point(478, 11);
            this.AvgVelt.Name = "AvgVelt";
            this.AvgVelt.ReadOnly = true;
            this.AvgVelt.Size = new System.Drawing.Size(92, 20);
            this.AvgVelt.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "New Average";
            // 
            // startMaxwell
            // 
            this.startMaxwell.Enabled = false;
            this.startMaxwell.Location = new System.Drawing.Point(12, 339);
            this.startMaxwell.Name = "startMaxwell";
            this.startMaxwell.Size = new System.Drawing.Size(75, 23);
            this.startMaxwell.TabIndex = 12;
            this.startMaxwell.Text = "Collide";
            this.startMaxwell.UseVisualStyleBackColor = true;
            this.startMaxwell.Click += new System.EventHandler(this.startMaxwell_Click);
            // 
            // allText
            // 
            this.allText.GridLines = true;
            this.allText.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.allText.Location = new System.Drawing.Point(335, 45);
            this.allText.Name = "allText";
            this.allText.Size = new System.Drawing.Size(406, 256);
            this.allText.TabIndex = 13;
            this.allText.UseCompatibleStateImageBehavior = false;
            this.allText.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.allText_ColumnWidthChanging);
            this.allText.SelectedIndexChanged += new System.EventHandler(this.allText_SelectedIndexChanged);
            // 
            // calc
            // 
            this.calc.Location = new System.Drawing.Point(12, 310);
            this.calc.Name = "calc";
            this.calc.Size = new System.Drawing.Size(75, 23);
            this.calc.TabIndex = 14;
            this.calc.Text = "Calculate";
            this.calc.UseVisualStyleBackColor = true;
            this.calc.Click += new System.EventHandler(this.calc_Click);
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(113, 45);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(0, 13);
            this.debug.TabIndex = 15;
            this.debug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // maxVelt
            // 
            this.maxVelt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.maxVelt.Location = new System.Drawing.Point(649, 11);
            this.maxVelt.Name = "maxVelt";
            this.maxVelt.ReadOnly = true;
            this.maxVelt.Size = new System.Drawing.Size(92, 20);
            this.maxVelt.TabIndex = 16;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.DataSource = this.chart1.ChartAreas;
            this.chart1.Location = new System.Drawing.Point(15, 45);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Name = "Series1";
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(314, 256);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "mwBolt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(403, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "label3";
            // 
            // Maxwell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 374);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.maxVelt);
            this.Controls.Add(this.debug);
            this.Controls.Add(this.calc);
            this.Controls.Add(this.allText);
            this.Controls.Add(this.startMaxwell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AvgVelt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tempn);
            this.Controls.Add(this.templ);
            this.Controls.Add(this.aopl);
            this.Controls.Add(this.aopn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Maxwell";
            this.Text = "Xenon Collision Simulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aopn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label aopl;
        private System.Windows.Forms.Label templ;
        private System.Windows.Forms.NumericUpDown tempn;
        public System.Windows.Forms.NumericUpDown aopn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AvgVelt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startMaxwell;
        private System.Windows.Forms.ListView allText;
        private System.Windows.Forms.Button calc;
        private System.Windows.Forms.Label debug;
        private System.Windows.Forms.TextBox maxVelt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

