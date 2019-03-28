using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace wfFilling_KPI
{
    public partial class ucGauge : UserControl
    {
        private System.Windows.Forms.AGaugeLabel labelValue;
        private System.Windows.Forms.AGaugeRange stopRange;
        private System.Windows.Forms.AGaugeRange alertRange;
        private System.Windows.Forms.AGaugeRange normalRange;

        /// <summary>
        /// 仪表盘画布的X,Y放大倍数，默认1
        /// </summary>
        private float multipleX = 1;
        private float multipleY = 1;


        public ucGauge()
        {
            InitializeComponent();
            labelValue = aGauge1.GaugeLabels.FindByName("GaugeLabelValue");
            stopRange = aGauge1.GaugeRanges.FindByName("StopRange");
            alertRange = aGauge1.GaugeRanges.FindByName("AlertRange");
            normalRange = aGauge1.GaugeRanges.FindByName("NormalRange");
            labelValue.Color = Color.Red;
            labelValue.Text = "NA";
        }


        public float fValue
        {
           get
           {
                return aGauge1.Value;
           }
           set
            {
                aGauge1.Value = value;
            }
        }


        private void initGaugeConfiguration()
        {
            multipleX = (float)this.Width / 300;//计算宽放大倍数
            multipleY = (float)this.Height / 250; //计算高放大倍数
            
            this.aGauge1.Center = new System.Drawing.Point( (int)(150 * multipleX), (int)(180 * multipleY));
            labelValue.Position = new System.Drawing.Point((int)(this.Width/2 - 30), (int)(200 * multipleY));
            if (aGauge1.Value.Equals(0f)) {
                labelValue.Text = "NA %";
            }
        }

        private void aGauge1_ValueChanged(object sender, EventArgs e)
        {

            labelValue.Text = (aGauge1.Value.Equals(0f))? "NA %" : aGauge1.Value.ToString() + "%";
        }

        private void aGauge1_ValueInRangeChanged(object sender, ValueInRangeChangedEventArgs e)
        {
            if (e.Range == stopRange && e.InRange)
            {
                labelValue.Color = Color.Red;
            }
            else if (e.Range == alertRange && e.InRange)
            {
                labelValue.Color = Color.Gold;
            }
            else if (e.Range == normalRange && e.InRange)
            {
                labelValue.Color = Color.Lime;
            }
        }

        private void ucGauge_Resize(object sender, EventArgs e)
        {
            initGaugeConfiguration();
        }

        private void ucGauge_Load(object sender, EventArgs e)
        {
            initGaugeConfiguration();
        }
    }
}
