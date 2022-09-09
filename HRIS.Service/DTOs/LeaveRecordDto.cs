using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class LeaveRecordDto
    {
        public string? EmployeeId { get; set; }
        public int? Status { get; set; }
        public DateTime FiledDate { get; set; }
        public DateTime DateLeaveFrom { get; set; }
        public DateTime DateLeaveTo { get; set; }
        public string? Reason { get; set; }
        public string? UserId { get; set; }
        public string? Remarks { get; set; }
        public string? LeaveType { get; set; }

    }
}
