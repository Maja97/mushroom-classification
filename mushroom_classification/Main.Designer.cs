namespace mushroom_classification
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_edit = new MetroFramework.Controls.MetroButton();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.mushroomGrid = new MetroFramework.Controls.MetroGrid();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_back = new MetroFramework.Controls.MetroButton();
            this.btn_results = new MetroFramework.Controls.MetroButton();
            this.btn_add = new MetroFramework.Controls.MetroButton();
            this.btn_stats = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMushroomNumber = new MetroFramework.Controls.MetroLabel();
            this.labelEdibleNumber = new MetroFramework.Controls.MetroLabel();
            this.labelPoisonousNumber = new MetroFramework.Controls.MetroLabel();
            this.edible = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bruises = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gill_spacing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gill_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalk_surface_above_ring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stalk_surface_below_ring = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ring_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.population = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(876, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(178, 262);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(161, 42);
            this.btn_edit.TabIndex = 20;
            this.btn_edit.Text = "Edit mushroom";
            this.btn_edit.UseSelectable = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel10.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel10.Location = new System.Drawing.Point(242, 72);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(150, 25);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "My mushrooms";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel11.Location = new System.Drawing.Point(57, 135);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(165, 20);
            this.metroLabel11.TabIndex = 23;
            this.metroLabel11.Text = "Number of mushrooms:";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel12.Location = new System.Drawing.Point(57, 172);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(54, 20);
            this.metroLabel12.TabIndex = 24;
            this.metroLabel12.Text = "Edible:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel13.Location = new System.Drawing.Point(57, 210);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(78, 20);
            this.metroLabel13.TabIndex = 25;
            this.metroLabel13.Text = "Poisonous:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroPanel2);
            this.metroPanel1.Controls.Add(this.btn_results);
            this.metroPanel1.Controls.Add(this.btn_add);
            this.metroPanel1.Controls.Add(this.btn_stats);
            this.metroPanel1.Controls.Add(this.pictureBox1);
            this.metroPanel1.Controls.Add(this.labelMushroomNumber);
            this.metroPanel1.Controls.Add(this.labelEdibleNumber);
            this.metroPanel1.Controls.Add(this.labelPoisonousNumber);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.btn_edit);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(876, 522);
            this.metroPanel1.TabIndex = 27;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.mushroomGrid);
            this.metroPanel2.Controls.Add(this.chart1);
            this.metroPanel2.Controls.Add(this.btn_back);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(876, 522);
            this.metroPanel2.TabIndex = 34;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            this.metroPanel2.Visible = false;
            // 
            // mushroomGrid
            // 
            this.mushroomGrid.AllowUserToAddRows = false;
            this.mushroomGrid.AllowUserToDeleteRows = false;
            this.mushroomGrid.AllowUserToResizeColumns = false;
            this.mushroomGrid.AllowUserToResizeRows = false;
            this.mushroomGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mushroomGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mushroomGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mushroomGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mushroomGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mushroomGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mushroomGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edible,
            this.bruises,
            this.gill_spacing,
            this.gill_size,
            this.stalk_surface_above_ring,
            this.stalk_surface_below_ring,
            this.ring_type,
            this.population,
            this.habitat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mushroomGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.mushroomGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.mushroomGrid.EnableHeadersVisualStyles = false;
            this.mushroomGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mushroomGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mushroomGrid.Location = new System.Drawing.Point(0, 82);
            this.mushroomGrid.Name = "mushroomGrid";
            this.mushroomGrid.ReadOnly = true;
            this.mushroomGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mushroomGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mushroomGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mushroomGrid.RowTemplate.Height = 24;
            this.mushroomGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mushroomGrid.Size = new System.Drawing.Size(561, 377);
            this.mushroomGrid.TabIndex = 5;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(567, 122);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "s1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(306, 326);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(658, 25);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(144, 40);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "Back";
            this.btn_back.UseSelectable = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_results
            // 
            this.btn_results.Location = new System.Drawing.Point(178, 320);
            this.btn_results.Name = "btn_results";
            this.btn_results.Size = new System.Drawing.Size(161, 42);
            this.btn_results.TabIndex = 36;
            this.btn_results.Text = "Check results";
            this.btn_results.UseSelectable = true;
            this.btn_results.Click += new System.EventHandler(this.btn_results_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(114, 380);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(278, 39);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Add mushroom to table";
            this.btn_add.UseSelectable = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(658, 25);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(144, 40);
            this.btn_stats.TabIndex = 33;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseSelectable = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(480, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // labelMushroomNumber
            // 
            this.labelMushroomNumber.AutoSize = true;
            this.labelMushroomNumber.Location = new System.Drawing.Point(345, 135);
            this.labelMushroomNumber.Name = "labelMushroomNumber";
            this.labelMushroomNumber.Size = new System.Drawing.Size(15, 20);
            this.labelMushroomNumber.TabIndex = 30;
            this.labelMushroomNumber.Text = "-";
            // 
            // labelEdibleNumber
            // 
            this.labelEdibleNumber.AutoSize = true;
            this.labelEdibleNumber.Location = new System.Drawing.Point(345, 172);
            this.labelEdibleNumber.Name = "labelEdibleNumber";
            this.labelEdibleNumber.Size = new System.Drawing.Size(15, 20);
            this.labelEdibleNumber.TabIndex = 29;
            this.labelEdibleNumber.Text = "-";
            // 
            // labelPoisonousNumber
            // 
            this.labelPoisonousNumber.AutoSize = true;
            this.labelPoisonousNumber.Location = new System.Drawing.Point(345, 210);
            this.labelPoisonousNumber.Name = "labelPoisonousNumber";
            this.labelPoisonousNumber.Size = new System.Drawing.Size(15, 20);
            this.labelPoisonousNumber.TabIndex = 28;
            this.labelPoisonousNumber.Text = "-";
            // 
            // edible
            // 
            this.edible.HeaderText = "Edible?";
            this.edible.Name = "edible";
            this.edible.ReadOnly = true;
            // 
            // bruises
            // 
            this.bruises.HeaderText = "Bruises";
            this.bruises.Name = "bruises";
            this.bruises.ReadOnly = true;
            // 
            // gill_spacing
            // 
            this.gill_spacing.HeaderText = "Gill spacing";
            this.gill_spacing.Name = "gill_spacing";
            this.gill_spacing.ReadOnly = true;
            // 
            // gill_size
            // 
            this.gill_size.HeaderText = "Gill size";
            this.gill_size.Name = "gill_size";
            this.gill_size.ReadOnly = true;
            // 
            // stalk_surface_above_ring
            // 
            this.stalk_surface_above_ring.HeaderText = "Stalk surface above ring";
            this.stalk_surface_above_ring.Name = "stalk_surface_above_ring";
            this.stalk_surface_above_ring.ReadOnly = true;
            // 
            // stalk_surface_below_ring
            // 
            this.stalk_surface_below_ring.HeaderText = "Stalk surface below ring";
            this.stalk_surface_below_ring.Name = "stalk_surface_below_ring";
            this.stalk_surface_below_ring.ReadOnly = true;
            // 
            // ring_type
            // 
            this.ring_type.HeaderText = "Ring type";
            this.ring_type.Name = "ring_type";
            this.ring_type.ReadOnly = true;
            // 
            // population
            // 
            this.population.HeaderText = "Population";
            this.population.Name = "population";
            this.population.ReadOnly = true;
            // 
            // habitat
            // 
            this.habitat.HeaderText = "Habitat";
            this.habitat.Name = "habitat";
            this.habitat.ReadOnly = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 630);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Mushroom classification tool";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mushroomGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btn_edit;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel labelMushroomNumber;
        private MetroFramework.Controls.MetroLabel labelEdibleNumber;
        private MetroFramework.Controls.MetroLabel labelPoisonousNumber;
        private MetroFramework.Controls.MetroButton btn_stats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroButton btn_back;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid mushroomGrid;
        private MetroFramework.Controls.MetroButton btn_add;
        private MetroFramework.Controls.MetroButton btn_results;
        private System.Windows.Forms.DataGridViewTextBoxColumn edible;
        private System.Windows.Forms.DataGridViewTextBoxColumn bruises;
        private System.Windows.Forms.DataGridViewTextBoxColumn gill_spacing;
        private System.Windows.Forms.DataGridViewTextBoxColumn gill_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn stalk_surface_above_ring;
        private System.Windows.Forms.DataGridViewTextBoxColumn stalk_surface_below_ring;
        private System.Windows.Forms.DataGridViewTextBoxColumn ring_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn population;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitat;
    }
}