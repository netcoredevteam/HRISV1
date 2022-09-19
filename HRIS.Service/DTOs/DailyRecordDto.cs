using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class DailyRecordDto
    {
        public Guid Id { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime LunchIn { get; set; }
        public DateTime LunchOut { get; set; }
        public DateTime OTIn { get; set; }
        public DateTime OTOut { get; set; }
    }
}
