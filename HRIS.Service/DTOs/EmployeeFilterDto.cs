using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class EmployeeFilterDto
    {
        public string? EmployeeNo { get; set; }
        public string? Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
