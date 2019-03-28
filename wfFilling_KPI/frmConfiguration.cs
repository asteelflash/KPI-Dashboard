using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfFilling_KPI.Model;

namespace wfFilling_KPI
{
    public partial class frmConfiguration : Form
    {
        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            txtLine.Text = Configuration.Line;
            txtSwitchTabInterval.Text = Configuration.SwitchTabInterval.ToString();
            txtRefreshDataInterval.Text = Configuration.RefreshDataInterval.ToString();
            dtpWorkDate.Value = DateTime.Parse( Configuration.WorkDate);
            cboShift.SelectedText = Configuration.WorkShift;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Configuration.Line = txtLine.Text.Trim().ToUpper();
            Configuration.WorkDate = dtpWorkDate.Value.ToString("yyyy-MM-dd");
            Configuration.WorkShift = cboShift.Text;

            int oResult = 0;
            if (int.TryParse(txtSwitchTabInterval.Text, out oResult))
            {
                Configuration.SwitchTabInterval = (oResult < 30) ? 30 : oResult;    //default min value equals 30 seconds
            }

            oResult = 0;
            if (int.TryParse(txtRefreshDataInterval.Text, out oResult))
            {               
                Configuration.RefreshDataInterval = (oResult < 10) ? 10 : oResult;  //default min value equals 10 minutes
            }       
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
