using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using wfFilling_KPI.Model;
using wfFilling_KPI.Helper;

namespace wfFilling_KPI.DAL
{
    class DALSqlserver
    {
        DBHelper db = new DBHelper();
        public DataSet GetDeviceOutputData(string workShift,string line, string startTime, string endTime)
        {
            
            string sql = string.Format("[sp_Juul_device_kpi_get_output_data] '{0}', '{1}', '{2}', '{3}'", workShift, line, startTime, endTime);
            return db.ExecuteReturnDataSet(sql);
        }

        public DataTable GetDeviceYieldData(string workShift, string line, string startTime, string endTime)
        {
            string sql = string.Format("[sp_Juul_device_kpi_get_yield_data] '{0}', '{1}', '{2}', '{3}'", workShift, line, startTime, endTime);
            return db.ExecuteReturnDataTable(sql);
        }



    }
}
