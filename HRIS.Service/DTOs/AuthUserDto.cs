using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class AuthUserDto
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="user"></param>
        /// <param name="token"></param>
        public AuthUserDto(UserEmployeeDto userEmployee, string? token)
        {
            Id = userEmployee.EmployeeNo;
            FirstName = userEmployee.FirstName;
            LastName = userEmployee.LastName;
            Username = userEmployee.Username;
            Token = token;
        }
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Username { get; set; }
        public string? Token { get; set; }
    }
}
