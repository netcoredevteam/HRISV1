using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public Employee()
        {
            this.Users = new Collection<User>();
            this.DailyRecords = new Collection<DailyRecord>();
            this.WorkPosition = new();
        }

        public string? EmployeeNo { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime BirthDate { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? ContactName { get; set; }
        public string? ContactNo { get; set; }

        //Work Position
        public Guid WorkPositionId { get; set; }
        public WorkPosition? WorkPosition { get; set; }

        //Schedule
        public Guid ScheduleId { get; set; }
        public Schedule? Schedule { get; set; }

        public string? ProfileImage { get; set; }




        // Navigation Properties
        public ICollection<User> Users { get; set; }

        public ICollection<DailyRecord> DailyRecords { get; set; }
    }
}
