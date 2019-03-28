namespace wfFilling_KPI
{
    partial class frmKPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKPI));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblWorkDate = new System.Windows.Forms.Label();
            this.btnTab3 = new System.Windows.Forms.Button();
            this.btnTab2 = new System.Windows.Forms.Button();
            this.btnTab1 = new System.Windows.Forms.Button();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnRefreshChart = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.picLoading1 = new System.Windows.Forms.PictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbKPI = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblTimeGap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbActualCumulativeQty = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblQtyGap = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.picLoading3 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblStation6 = new System.Windows.Forms.Label();
            this.lblStation5 = new System.Windows.Forms.Label();
            this.lblStation4 = new System.Windows.Forms.Label();
            this.lblStation3 = new System.Windows.Forms.Label();
            this.lblStation2 = new System.Windows.Forms.Label();
            this.lblStation1 = new System.Windows.Forms.Label();
            this.timerRefreshChar = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerSwitchTab = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ucGauge6 = new wfFilling_KPI.ucGauge();
            this.ucGauge5 = new wfFilling_KPI.ucGauge();
            this.ucGauge4 = new wfFilling_KPI.ucGauge();
            this.ucGauge1 = new wfFilling_KPI.ucGauge();
            this.ucGauge2 = new wfFilling_KPI.ucGauge();
            this.ucGauge3 = new wfFilling_KPI.ucGauge();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading3)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefreshChart);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1064, 697);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.Controls.Add(this.lblShift, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblWorkDate, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTab3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTab2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnTab1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLine, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(774, 45);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblShift.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShift.Location = new System.Drawing.Point(603, 0);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(144, 45);
            this.lblShift.TabIndex = 5;
            this.lblShift.Text = "Shfit";
            this.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWorkDate
            // 
            this.lblWorkDate.AutoSize = true;
            this.lblWorkDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkDate.Location = new System.Drawing.Point(303, 0);
            this.lblWorkDate.Name = "lblWorkDate";
            this.lblWorkDate.Size = new System.Drawing.Size(294, 45);
            this.lblWorkDate.TabIndex = 4;
            this.lblWorkDate.Text = "WorkDate";
            this.lblWorkDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnTab3
            // 
            this.btnTab3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTab3.FlatAppearance.BorderSize = 0;
            this.btnTab3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab3.Image = global::wfFilling_KPI.Properties.Resources.OEE;
            this.btnTab3.Location = new System.Drawing.Point(103, 3);
            this.btnTab3.Name = "btnTab3";
            this.btnTab3.Size = new System.Drawing.Size(44, 39);
            this.btnTab3.TabIndex = 2;
            this.btnTab3.Tag = "3";
            this.btnTab3.UseVisualStyleBackColor = true;
            this.btnTab3.Click += new System.EventHandler(this.btnTab3_Click);
            // 
            // btnTab2
            // 
            this.btnTab2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTab2.FlatAppearance.BorderSize = 0;
            this.btnTab2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab2.Image = global::wfFilling_KPI.Properties.Resources.FPY;
            this.btnTab2.Location = new System.Drawing.Point(53, 3);
            this.btnTab2.Name = "btnTab2";
            this.btnTab2.Size = new System.Drawing.Size(44, 39);
            this.btnTab2.TabIndex = 1;
            this.btnTab2.Tag = "2";
            this.btnTab2.UseVisualStyleBackColor = true;
            this.btnTab2.Click += new System.EventHandler(this.btnTab2_Click);
            // 
            // btnTab1
            // 
            this.btnTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTab1.FlatAppearance.BorderSize = 0;
            this.btnTab1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTab1.Image = ((System.Drawing.Image)(resources.GetObject("btnTab1.Image")));
            this.btnTab1.Location = new System.Drawing.Point(3, 3);
            this.btnTab1.Name = "btnTab1";
            this.btnTab1.Size = new System.Drawing.Size(44, 39);
            this.btnTab1.TabIndex = 0;
            this.btnTab1.Tag = "1";
            this.btnTab1.UseVisualStyleBackColor = true;
            this.btnTab1.Click += new System.EventHandler(this.btnTab1_Click);
            // 
            // lblLine
            // 
            this.lblLine.AutoSize = true;
            this.lblLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLine.Location = new System.Drawing.Point(153, 0);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(144, 45);
            this.lblLine.TabIndex = 3;
            this.lblLine.Text = "Line";
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefreshChart
            // 
            this.btnRefreshChart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefreshChart.FlatAppearance.BorderSize = 0;
            this.btnRefreshChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshChart.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshChart.Image")));
            this.btnRefreshChart.Location = new System.Drawing.Point(1014, 0);
            this.btnRefreshChart.Name = "btnRefreshChart";
            this.btnRefreshChart.Size = new System.Drawing.Size(50, 45);
            this.btnRefreshChart.TabIndex = 6;
            this.btnRefreshChart.UseVisualStyleBackColor = true;
            this.btnRefreshChart.Click += new System.EventHandler(this.btnRefreshChart_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 648);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.picLoading1);
            this.splitContainer2.Panel1.Controls.Add(this.chart1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(1050, 616);
            this.splitContainer2.SplitterDistance = 854;
            this.splitContainer2.TabIndex = 0;
            // 
            // picLoading1
            // 
            this.picLoading1.Image = global::wfFilling_KPI.Properties.Resources.loading1;
            this.picLoading1.Location = new System.Drawing.Point(540, 300);
            this.picLoading1.Name = "picLoading1";
            this.picLoading1.Size = new System.Drawing.Size(50, 50);
            this.picLoading1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading1.TabIndex = 2;
            this.picLoading1.TabStop = false;
            this.picLoading1.Visible = false;
            // 
            // chart1
            // 
            chartArea1.AlignWithChartArea = "ChartArea2";
            chartArea1.Name = "ChartArea1";
            chartArea2.AlignWithChartArea = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.DockedToChartArea = "ChartArea1";
            legend1.IsDockedInsideChartArea = false;
            legend1.Name = "Legend1";
            legend2.DockedToChartArea = "ChartArea2";
            legend2.IsDockedInsideChartArea = false;
            legend2.Name = "Legend2";
            this.chart1.Legends.Add(legend1);
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.BorderWidth = 3;
            series3.ChartArea = "ChartArea2";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Lime;
            series3.Legend = "Legend2";
            series3.Name = "Series3";
            series4.BorderWidth = 3;
            series4.ChartArea = "ChartArea2";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series4.Legend = "Legend2";
            series4.Name = "Series4";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(854, 616);
            this.chart1.TabIndex = 1;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title1";
            title1.Text = "Output Quantity Tendency chart";
            this.chart1.Titles.Add(title1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 616);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbKPI);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KPI Rate";
            // 
            // lbKPI
            // 
            this.lbKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbKPI.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKPI.Location = new System.Drawing.Point(3, 16);
            this.lbKPI.Name = "lbKPI";
            this.lbKPI.Size = new System.Drawing.Size(180, 124);
            this.lbKPI.TabIndex = 1;
            this.lbKPI.Text = "KPI";
            this.lbKPI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblTimeGap);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(3, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 143);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Time +/-";
            // 
            // lblTimeGap
            // 
            this.lblTimeGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimeGap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeGap.Location = new System.Drawing.Point(3, 16);
            this.lblTimeGap.Name = "lblTimeGap";
            this.lblTimeGap.Size = new System.Drawing.Size(180, 124);
            this.lblTimeGap.TabIndex = 3;
            this.lblTimeGap.Text = "Time Gap";
            this.lblTimeGap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbActualCumulativeQty);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 143);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actual Cumulative Qty";
            // 
            // lbActualCumulativeQty
            // 
            this.lbActualCumulativeQty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbActualCumulativeQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbActualCumulativeQty.Location = new System.Drawing.Point(3, 16);
            this.lbActualCumulativeQty.Name = "lbActualCumulativeQty";
            this.lbActualCumulativeQty.Size = new System.Drawing.Size(180, 124);
            this.lbActualCumulativeQty.TabIndex = 2;
            this.lbActualCumulativeQty.Text = "Actual Qty";
            this.lbActualCumulativeQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblQtyGap);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 143);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Running Qty +/-";
            // 
            // lblQtyGap
            // 
            this.lblQtyGap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQtyGap.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtyGap.Location = new System.Drawing.Point(3, 16);
            this.lblQtyGap.Name = "lblQtyGap";
            this.lblQtyGap.Size = new System.Drawing.Size(180, 124);
            this.lblQtyGap.TabIndex = 3;
            this.lblQtyGap.Text = "Qty Gap";
            this.lblQtyGap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.picLoading3);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 622);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // picLoading3
            // 
            this.picLoading3.Image = global::wfFilling_KPI.Properties.Resources.loading1;
            this.picLoading3.Location = new System.Drawing.Point(503, 286);
            this.picLoading3.Name = "picLoading3";
            this.picLoading3.Size = new System.Drawing.Size(50, 50);
            this.picLoading3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLoading3.TabIndex = 3;
            this.picLoading3.TabStop = false;
            this.picLoading3.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel3.Controls.Add(this.lblStation6, 2, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblStation5, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblStation4, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge6, 2, 3);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge5, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge4, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblStation3, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblStation2, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucGauge3, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblStation1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1050, 616);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // lblStation6
            // 
            this.lblStation6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation6.Location = new System.Drawing.Point(702, 556);
            this.lblStation6.Name = "lblStation6";
            this.lblStation6.Size = new System.Drawing.Size(345, 30);
            this.lblStation6.TabIndex = 11;
            this.lblStation6.Text = "lblStation6";
            this.lblStation6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation5
            // 
            this.lblStation5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation5.Location = new System.Drawing.Point(352, 556);
            this.lblStation5.Name = "lblStation5";
            this.lblStation5.Size = new System.Drawing.Size(344, 30);
            this.lblStation5.TabIndex = 10;
            this.lblStation5.Text = "lblStation5";
            this.lblStation5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation4
            // 
            this.lblStation4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation4.Location = new System.Drawing.Point(3, 556);
            this.lblStation4.Name = "lblStation4";
            this.lblStation4.Size = new System.Drawing.Size(343, 30);
            this.lblStation4.TabIndex = 9;
            this.lblStation4.Text = "lblStation4";
            this.lblStation4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation3
            // 
            this.lblStation3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation3.Location = new System.Drawing.Point(702, 253);
            this.lblStation3.Name = "lblStation3";
            this.lblStation3.Size = new System.Drawing.Size(345, 30);
            this.lblStation3.TabIndex = 5;
            this.lblStation3.Text = "lblStation3";
            this.lblStation3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation2
            // 
            this.lblStation2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation2.Location = new System.Drawing.Point(352, 253);
            this.lblStation2.Name = "lblStation2";
            this.lblStation2.Size = new System.Drawing.Size(344, 30);
            this.lblStation2.TabIndex = 4;
            this.lblStation2.Text = "lblStation2";
            this.lblStation2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStation1
            // 
            this.lblStation1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation1.Location = new System.Drawing.Point(3, 253);
            this.lblStation1.Name = "lblStation1";
            this.lblStation1.Size = new System.Drawing.Size(343, 30);
            this.lblStation1.TabIndex = 3;
            this.lblStation1.Text = "lblStation1";
            this.lblStation1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerRefreshChar
            // 
            this.timerRefreshChar.Interval = 300000;
            this.timerRefreshChar.Tick += new System.EventHandler(this.timerRefreshChar_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configurationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1064, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "Configuration";
            this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
            // 
            // timerSwitchTab
            // 
            this.timerSwitchTab.Tick += new System.EventHandler(this.timerSwitchTab_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 699);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1064, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "refreshStatus";
            // 
            // ucGauge6
            // 
            this.ucGauge6.BackColor = System.Drawing.Color.White;
            this.ucGauge6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge6.fValue = 80F;
            this.ucGauge6.Location = new System.Drawing.Point(702, 306);
            this.ucGauge6.Name = "ucGauge6";
            this.ucGauge6.Size = new System.Drawing.Size(345, 247);
            this.ucGauge6.TabIndex = 8;
            // 
            // ucGauge5
            // 
            this.ucGauge5.BackColor = System.Drawing.Color.White;
            this.ucGauge5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge5.fValue = 80F;
            this.ucGauge5.Location = new System.Drawing.Point(352, 306);
            this.ucGauge5.Name = "ucGauge5";
            this.ucGauge5.Size = new System.Drawing.Size(344, 247);
            this.ucGauge5.TabIndex = 7;
            // 
            // ucGauge4
            // 
            this.ucGauge4.BackColor = System.Drawing.Color.White;
            this.ucGauge4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge4.fValue = 80F;
            this.ucGauge4.Location = new System.Drawing.Point(3, 306);
            this.ucGauge4.Name = "ucGauge4";
            this.ucGauge4.Size = new System.Drawing.Size(343, 247);
            this.ucGauge4.TabIndex = 6;
            // 
            // ucGauge1
            // 
            this.ucGauge1.BackColor = System.Drawing.Color.White;
            this.ucGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge1.fValue = 80F;
            this.ucGauge1.Location = new System.Drawing.Point(3, 3);
            this.ucGauge1.Name = "ucGauge1";
            this.ucGauge1.Size = new System.Drawing.Size(343, 247);
            this.ucGauge1.TabIndex = 0;
            // 
            // ucGauge2
            // 
            this.ucGauge2.BackColor = System.Drawing.Color.White;
            this.ucGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge2.fValue = 80F;
            this.ucGauge2.Location = new System.Drawing.Point(352, 3);
            this.ucGauge2.Name = "ucGauge2";
            this.ucGauge2.Size = new System.Drawing.Size(344, 247);
            this.ucGauge2.TabIndex = 1;
            // 
            // ucGauge3
            // 
            this.ucGauge3.BackColor = System.Drawing.Color.White;
            this.ucGauge3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucGauge3.fValue = 80F;
            this.ucGauge3.Location = new System.Drawing.Point(702, 3);
            this.ucGauge3.Name = "ucGauge3";
            this.ucGauge3.Size = new System.Drawing.Size(345, 247);
            this.ucGauge3.TabIndex = 2;
            // 
            // frmKPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 721);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmKPI";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.frmKPI_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading3)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnRefreshChart;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbKPI;
        private System.Windows.Forms.Label lbActualCumulativeQty;
        private System.Windows.Forms.Label lblTimeGap;
        private System.Windows.Forms.Label lblQtyGap;
        private System.Windows.Forms.Timer timerRefreshChar;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblWorkDate;
        private System.Windows.Forms.Button btnTab3;
        private System.Windows.Forms.Button btnTab2;
        private System.Windows.Forms.Button btnTab1;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Timer timerSwitchTab;
        private System.Windows.Forms.PictureBox picLoading1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblStation6;
        private System.Windows.Forms.Label lblStation5;
        private System.Windows.Forms.Label lblStation4;
        private ucGauge ucGauge6;
        private ucGauge ucGauge5;
        private ucGauge ucGauge4;
        private System.Windows.Forms.Label lblStation3;
        private System.Windows.Forms.Label lblStation2;
        private ucGauge ucGauge1;
        private ucGauge ucGauge2;
        private ucGauge ucGauge3;
        private System.Windows.Forms.Label lblStation1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.PictureBox picLoading3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

