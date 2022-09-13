using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Utility.Helpers
{
    public class DateTimeHelper
    {
        public static string GetTimeFormat(DateTime dateTime)
        {
            return dateTime.ToString("HH:mm:ss");
        }

        public static string GetDateFormat(DateTime dateTime)
        {
            return dateTime.ToString("MM/dd/yyyy");
        }
    }
}
