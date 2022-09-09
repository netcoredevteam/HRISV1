using HRIS.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {
            this.Employee = new();
            this.LeaveRecords = new Collection<LeaveRecord>();
        }

        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Nickname { get; set; }
        public Status Status { get; set; }
        public DateTime LastLoginTime { get; set; }
        public string? ProfileImage { get; set; }

        // Navigation Properties
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public ICollection<LeaveRecord> LeaveRecords { get; set; }
    }
}
