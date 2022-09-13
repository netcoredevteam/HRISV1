using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class DailyRecordSearchDto
    {
        public string? EmployeeNo { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
