using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class LeaveRecord : BaseEntity
    {
        //public Guid EmployeeId { get; set; }
        //public Employee? Employee { get; set; }

        public LeaveRecord()
        {
            this.User = new();
        }

        public int Status { get; set; }
        public DateTime FiledDate { get; set; }
        public DateTime LeaveStartDate { get; set; }
        public DateTime LeaveEndDate { get; set; }
        public string? ReasonOfLeave { get; set; }
        public string? Remarks { get; set; }

        /// <summary>
        /// 1 with pay, 0 w/o pay
        /// </summary>
        public int Leavetype { get; set; }

        // navigation properties
        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
