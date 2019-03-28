using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfFilling_KPI.Model
{
    class Configuration
    {
        public static string Line {get;set;}

        public static string WorkDate { get; set; }

        public static string WorkShift { get; set; }

        public static int SwitchTabInterval { get; set; }

        public static int RefreshDataInterval { get; set; }

        public static string ifAutoRefresh { get; set; }
    }
}
