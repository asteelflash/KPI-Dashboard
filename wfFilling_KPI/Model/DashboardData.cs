using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace wfFilling_KPI.Model
{
    class DashboardData
    {
        public static DataSet OuputData { get; set; }

        public static DataTable YieldData { get; set; }

        public static DataSet OEEData { get; set; }
    }
}
