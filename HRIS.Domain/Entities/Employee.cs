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
        }

        public string? EmployeeId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateHired { get; set; }
        public DateTime BirthDate { get; set; }

        // Navigation Properties
        public ICollection<User> Users { get; set; }
    }
}
