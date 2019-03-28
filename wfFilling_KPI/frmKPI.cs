using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using wfFilling_KPI.Model;
using wfFilling_KPI.BLL;
using System.Threading;

namespace wfFilling_KPI
{
    public partial class frmKPI : Form
    {
        
        GetDataBll getDatabll = new GetDataBll();

        private int tabPageIndex=0;


        public frmKPI()
        {
            InitializeComponent();
        }

        private void frmKPI_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            getDatabll.InitConfiguration();
            RefreshBasicInfo();
            if (Configuration.ifAutoRefresh.Equals("1"))
            {               
                timerRefreshChar.Enabled = true;
            }
            timerSwitchTab.Enabled = true;
            btnRefreshChart_Click(sender, e);
        }

        private void RefreshBasicInfo()
        {
            lblLine.Text = String.Format("Line  {0}", Configuration.Line); 
            lblWorkDate.Text = String.Format("WorkDate  {0}", Configuration.WorkDate);
            lblShift.Text = String.Format("WorkShift  {0}", Configuration.WorkShift);
            timerSwitchTab.Interval = Configuration.SwitchTabInterval * 1000;
            timerRefreshChar.Interval = Configuration.RefreshDataInterval * 1000 * 60;
        }


        private void RefreshOutputChart()
        {
            SetPictureVisible(picLoading1, true);
            //Thread.Sleep(1000);    //模拟长时间查询；  
            SetStautsLableText("getOutput start;");
            getDatabll.GetOutputData();
            SetStautsLableText("getOutput end;");
            RefreshOutputChart(chart1, DashboardData.OuputData.Tables[0]);
            RefreshData(DashboardData.OuputData.Tables[1]);
            SetPictureVisible(picLoading1, false);
        }

        
        private void RefreshOEEChart()
        {
        }

        private void RefreshYIELDChart()
        {
            SetPictureVisible(picLoading3, true);
            //Thread.Sleep(2000);    //模拟长时间查询； 
            SetStautsLableText("getYield start;");
            getDatabll.GetYieldData();
            SetStautsLableText("getYield end;");
            for (int i = 0; i < DashboardData.YieldData.Rows.Count; i++)
            {
                Label lbl = (Label)GetControlInstance(tableLayoutPanel3, string.Format("lblStation{0}", (i + 1).ToString()));
                SetLabelText(lbl, DashboardData.YieldData.Rows[i][0].ToString());
                ucGauge ucg = (ucGauge)GetControlInstance(tableLayoutPanel3, string.Format("ucGauge{0}", (i + 1).ToString()));
                RefreshUcGauge(ucg, float.Parse(DashboardData.YieldData.Rows[i][1].ToString()));
            }
            SetPictureVisible(picLoading3, false);
        }

        private void initYieldChart()
        {
            IEnumerator Controls = null;//所有控件
            Control c = null;//当前控件
            object obj = tableLayoutPanel3;
            Controls = ((Control)obj).Controls.GetEnumerator();
            while (Controls.MoveNext())//遍历操作
            {
                c = (Control)Controls.Current;
                c.Visible = false;
            }
        }

        /// <summary>
        /// 根据指定容器和控件名字，获得控件
        /// </summary>
        /// <param name="obj">容器</param>
        /// <param name="strControlName">控件名字</param>
        /// <returns>控件</returns>
        private object GetControlInstance(object obj, string strControlName)
        {
            IEnumerator Controls = null;//所有控件
            Control c = null;//当前控件
            Object cResult = null;//查找结果
            if (obj.GetType() == this.GetType())//窗体
            {
                Controls = this.Controls.GetEnumerator();
            }
            else//控件
            {
                Controls = ((Control)obj).Controls.GetEnumerator();
            }
            while (Controls.MoveNext())//遍历操作
            {               
                c = (Control)Controls.Current;//当前控件
                var ctype = c.GetType();
                if (c.HasChildren && !c.GetType().BaseType.Name.Equals("UserControl"))//当前控件是个容器且不是UserControl
                {
                    cResult = GetControlInstance(c, strControlName);//递归查找
                    if (cResult == null)//当前容器中没有，跳出，继续查找
                        continue;
                    else//找到控件，返回
                        return cResult;
                }
                else if (c.Name == strControlName)//不是容器，同时找到控件，返回
                {
                    return c;
                }
            }
            return null;//控件不存在
        }


        private void RefreshData(DataTable dt)
        {
            string kpi = dt.Rows[0][0].ToString();
            string actual_qty = dt.Rows[0][1].ToString();
            string qtyGap = dt.Rows[0][2].ToString();
            string timeGap = dt.Rows[0][3].ToString();
            RefreshKpiAndActualQty(kpi, actual_qty);
            RefreshQtyAndTimeGap(qtyGap, timeGap);
        }

        private void RefreshKpiAndActualQty(string kpi, string actual_qty)
        {
            float fKPI = float.Parse(kpi);
            SetLabelText(lbKPI, kpi + "%");
            SetLabelText(lbActualCumulativeQty, actual_qty);

            //<80%=Red // 80% - 90% = Yellow // 90%-99% = Light Green // >99% = Dark green
            if (fKPI >= 80 && fKPI < 90)
            {
                SetLabelColor(lbKPI, Color.Gold);
                SetLabelColor(lbActualCumulativeQty, Color.Gold);
            }
            else if (fKPI >= 90 && fKPI < 99)
            {
                SetLabelColor(lbKPI, Color.LightGreen); 
                SetLabelColor(lbActualCumulativeQty, Color.LightGreen); 
            }
            else if (fKPI >= 99)
            {
                SetLabelColor(lbKPI, Color.DarkGreen);
                SetLabelColor(lbActualCumulativeQty, Color.DarkGreen); 
            }
            else
            {
                SetLabelColor(lbKPI, Color.Red);
                SetLabelColor(lbActualCumulativeQty, Color.Red);
            }
        }

        private void RefreshQtyAndTimeGap(string qtyGap, string timeGap)
        {
            int intQtyGap = int.Parse(qtyGap);
            SetLabelText(lblQtyGap, qtyGap);
            if (intQtyGap >= 0)
            {
                SetLabelColor(lblQtyGap, Color.DarkGreen); 
                SetLabelColor(lblTimeGap, Color.DarkGreen); 
            }
            else
            {
                SetLabelColor(lblQtyGap, Color.Red);
                SetLabelColor(lblTimeGap, Color.Red); 
            }

            int intTimeGap = int.Parse(timeGap);
            string sign = intTimeGap < 0 ? "-" : "";
            int intTimeGapAbsolute = System.Math.Abs(intTimeGap);
            int hour = intTimeGapAbsolute / 60;
            int minute = intTimeGapAbsolute % 60;
            SetLabelText(lblTimeGap, string.Format("{0}{1} h {2} m", sign, hour.ToString(), minute.ToString())); 
        }

        private void configurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguration form = new frmConfiguration();
            form.StartPosition = FormStartPosition.CenterParent;
            if (form.ShowDialog() == DialogResult.OK)
            {
                RefreshBasicInfo();
                btnRefreshChart_Click(sender, e);
            }
        }

        private void btnTab1_Click(object sender, EventArgs e)
        {
            ChangeTabPage(0);
        }

        private void btnTab2_Click(object sender, EventArgs e)
        {
            ChangeTabPage(1);
        }

        private void btnTab3_Click(object sender, EventArgs e)
        {
            //ChangeTabPage(2);
        }


        private void ChangeTabPage(int pageIndex)
        {
            this.tabControl1.TabPages[pageIndex].Show();
            tabControl1.SelectedIndex = pageIndex;
        }

        private void timerSwitchTab_Tick(object sender, EventArgs e)
        {
            ChangeTabPage(tabPageIndex % tabControl1.TabCount);
            tabPageIndex++;
        }

        private void timerRefreshChar_Tick(object sender, EventArgs e)
        {
            btnRefreshChart_Click(sender, e);
        }

        private void btnRefreshChart_Click(object sender, EventArgs e)
        {
            getDatabll.setTimeZones();
            getDatabll.ClearData();
            initYieldChart();
            Task[] arrTask = new Task[3];
            arrTask[0] = Task.Factory.StartNew(() => { RefreshOutputChart(); });
            arrTask[1] = Task.Factory.StartNew(() => { RefreshOEEChart(); });
            arrTask[2] = Task.Factory.StartNew(() => { RefreshYIELDChart(); });
            Task.WhenAll(arrTask).ContinueWith(p =>
            {
                SetStautsLableText(string.Format("{0}: 数据刷新完成",DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
            
        }

        #region 子线程刷新UI控件
        delegate void DelgateRefreshOutputChart(Chart chart, DataTable dt);
        private void RefreshOutputChart(Chart chart, DataTable dt)
        {
            if (chart.InvokeRequired)   //如果调用线程不是空间创建线程，则InvokeRequired=TRUE
            {
                DelgateRefreshOutputChart d = new DelgateRefreshOutputChart(RefreshOutputChart);
                this.Invoke(d, new object[] { chart, dt });
            }
            else
            {
                chart.DataSource = dt;
                chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
                chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;
                chart.ChartAreas["ChartArea2"].AxisX.MajorGrid.LineColor = System.Drawing.Color.Transparent;
                chart.ChartAreas["ChartArea2"].AxisY.MajorGrid.LineColor = System.Drawing.Color.Transparent;

                chart.ChartAreas["ChartArea1"].AxisY.Title = "Ouput Quantity Hourly";
                chart.ChartAreas["ChartArea1"].AxisX.Interval = 1;//设置X轴数值间隔
                chart.ChartAreas["ChartArea2"].AxisY.Title = "Ouput Quantity Cumulative";
                chart.ChartAreas["ChartArea2"].AxisX.Interval = 1;//设置X轴数值间隔

                //chart.Series.Clear();  //删除Series   
                for (int i = 0; i < dt.Columns.Count - 1; i++)
                {
                    chart.Series[i].Points.Clear(); //清空Series数据
                    chart.Series[i].XValueMember = dt.Columns[0].ColumnName;
                    chart.Series[i].YValueMembers = dt.Columns[i + 1].ColumnName;
                    //chart.Series[i].LegendToolTip = dt.Columns[i + 1].ColumnName;//鼠标放到系列上出现的文字 
                    chart.Series[i].LegendText = dt.Columns[i + 1].ColumnName;//系列名字
                    chart.Series[i].BorderWidth = 3;          
                }
                chart.Series[0].ChartType = SeriesChartType.Column;
                chart.Series[1].ChartType = SeriesChartType.Line;
                chart.Series[2].ChartType = SeriesChartType.Spline;
                chart.Series[3].ChartType = SeriesChartType.Spline;
                chart.Series[0].Label = "#VAL"; //显示数值
                chart.Series[2].Label = "#VAL"; //显示数值
            }
        }

        delegate void SetLabelTextCallback(Label lbl, string text);
        private void SetLabelText(Label lbl, string text)
        {
            if (lbl.InvokeRequired)   //如果调用线程不是空间创建线程，则InvokeRequired=TRUE
            {
                SetLabelTextCallback d = new SetLabelTextCallback(SetLabelText);
                this.Invoke(d, new object[] { lbl, text });
            }
            else
            {
                lbl.Text = text;
                lbl.Visible = true;
            }
        }

        delegate void SetLabelColorCallback(Label lbl, Color color);
        private void SetLabelColor(Label lbl, Color color)
        {
            if (lbl.InvokeRequired)   //如果调用线程不是空间创建线程，则InvokeRequired=TRUE
            {
                SetLabelColorCallback d = new SetLabelColorCallback(SetLabelColor);
                this.Invoke(d, new object[] { lbl, color });
            }
            else
            {
                lbl.ForeColor = color;
            }
        }

        delegate void SetPictureVisibleCallback(PictureBox pb, bool b);
        private void SetPictureVisible(PictureBox pb, bool b)
        {
            if (pb.InvokeRequired)   //如果调用线程不是空间创建线程，则InvokeRequired=TRUE
            {
                SetPictureVisibleCallback d = new SetPictureVisibleCallback(SetPictureVisible);
                this.Invoke(d, new object[] { pb, b });
            }
            else
            {
                pb.Dock = DockStyle.Fill;
                pb.Visible = b;
            }
        }

        delegate void DelgateRefreshUcGauge(ucGauge ucg, float f);
        private void RefreshUcGauge(ucGauge ucg, float f)
        {
            if (ucg.InvokeRequired)   //如果调用线程不是空间创建线程，则InvokeRequired=TRUE
            {
                DelgateRefreshUcGauge d = new DelgateRefreshUcGauge(RefreshUcGauge);
                this.Invoke(d, new object[] { ucg, f });
            }
            else
            {
                ucg.fValue = f;
                ucg.Visible = true;
            }
        }

        /// <summary>提示信息</summary>
        private void ShowNoticeMessage(string msg)
        {
            this.Invoke(new MessageBoxShow(MessageBoxShow_F), new object[] { msg });
        }
        delegate void MessageBoxShow(string msg);
        void MessageBoxShow_F(string msg)
        {
            MessageBox.Show(msg, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>提示信息</summary>
        private void SetStautsLableText(string msg)
        {
            this.Invoke(new StautsLableText(StautsLableText_F), new object[] { msg });
        }
        delegate void StautsLableText(string msg);
        void StautsLableText_F(string msg)
        {
            toolStripStatusLabel1.Text = msg;
        }

        #endregion

    }
        
}
