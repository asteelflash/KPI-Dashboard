using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfFilling_KPI.Model;
using wfFilling_KPI.DAL;
using wfFilling_KPI.Helper;


namespace wfFilling_KPI.BLL
{
    class GetDataBll
    {
        DALSqlserver dalsql = new DALSqlserver();

        public void InitConfiguration()
        {
            Configuration.Line = System.Configuration.ConfigurationManager.AppSettings["line"].ToString();
            Configuration.WorkDate = DateTime.Now.ToString("yyyy-MM-dd");
            int intHour = DateTime.Now.Hour;
            Configuration.WorkShift = (intHour > 7 && intHour < 20) ? "D" : "N";
            Configuration.SwitchTabInterval = int.Parse(System.Configuration.ConfigurationManager.AppSettings["switchTabInterval"].ToString());
            Configuration.RefreshDataInterval = int.Parse(System.Configuration.ConfigurationManager.AppSettings["refreshDataInterval"].ToString());
            Configuration.ifAutoRefresh = System.Configuration.ConfigurationManager.AppSettings["autoRefresh"].ToString();
            string connStr = System.Configuration.ConfigurationManager.AppSettings["connectionstringReport"].ToString();
            DBHelper.ConnString = Encrypt.DesDecrypt(connStr);
        }
        public void setTimeZones()
        {
            TimeZones.Line = Configuration.Line;
            TimeZones.WorkDate = Configuration.WorkDate;
            TimeZones.WorkShift = Configuration.WorkShift;
            TimeZones.StartTime = string.Empty;
            TimeZones.EndTime = string.Empty;
            if (TimeZones.WorkShift.Equals("D"))
            {
                TimeZones.StartTime = TimeZones.WorkDate + " 08";
                TimeZones.EndTime = TimeZones.WorkDate + " 19";
            }
            else if (TimeZones.WorkShift.Equals("N"))
            {
                TimeZones.StartTime = TimeZones.WorkDate + " 20";
                TimeZones.EndTime = DateTime.Parse(TimeZones.WorkDate).AddDays(1).ToString("yyyy-MM-dd") + " 07";
            }
        }

        public void ClearData()
        {
            DashboardData.OuputData = null;
            DashboardData.YieldData = null;
            DashboardData.OEEData = null;
        }

        public void GetOutputData()
        {
            DashboardData.OuputData = dalsql.GetDeviceOutputData(TimeZones.WorkShift, TimeZones.Line, TimeZones.StartTime, TimeZones.EndTime);          
        }

        public void GetYieldData()
        {
            DashboardData.YieldData = dalsql.GetDeviceYieldData(TimeZones.WorkShift, TimeZones.Line, TimeZones.StartTime, TimeZones.EndTime);        
        }

        public void GetOEEData()
        {
                                       
        }


    }
}
