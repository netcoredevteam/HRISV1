using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class DailyRecord : BaseEntity
    {
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public DateTime TimeIn { get; set; }
        public DateTime TimeOut { get; set; }
        public DateTime LunchIn { get; set; }
        public DateTime LunchOut { get; set; }
        public DateTime OTIn { get; set; }
        public DateTime OTOut { get; set; }
    }
}
