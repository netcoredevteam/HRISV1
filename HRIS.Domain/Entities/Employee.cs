using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string? EmployeeNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime Birthdate { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? EmergencyContactName { get; set; }
        public string? EmergencyContactNo { get; set; }
        public string? WorkPosition { get; set; }
        public Schedule Schedule { get; set; }
        public string? ScheduleId { get; set; }
        public string? ProfileImage { get; set; }
    }
}
