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
        public string? Nickname { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastLoginTime { get; set; }
        public UserRole UserRole { get; set; }
        public Status Status { get; set; }

        // Navigation Properties
        public Guid EmployeeId { get; set; }
        public Employee? Employee { get; set; }
    }
}
