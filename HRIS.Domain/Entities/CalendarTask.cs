using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class CalendarTask : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime DateTask { get; set; }
    }
}