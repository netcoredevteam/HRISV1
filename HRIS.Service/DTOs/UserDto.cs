using HRIS.Service.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public Guid EmployeeId { get; set; }
        public string? ProfileImage { get; set; }
    }
}
