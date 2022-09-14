using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Mandatory : BaseEntity
    {
        public string? SSS { get; set; }
        public string? PagIbig { get; set; }
        public string? PhilHealth { get; set; }
        public string? TIN { get; set; }
        public string? HMO { get; set; }

        // Navigation Properties
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
