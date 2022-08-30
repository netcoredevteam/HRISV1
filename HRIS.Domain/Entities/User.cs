using HRIS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class User : BaseEntity
    {
        public string? Username { get; set; }
        public string? Password { get; set; }
        public UserType UserType { get; set; }
        public Employee? Employee { get; set; }
        public Guid EmployeeId { get; set; }
    }
}
