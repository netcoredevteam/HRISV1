using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class WorkPosition : BaseEntity
    {
        public WorkPosition()
        {
            this.Employees = new Collection<Employee>();
        }

        public string? Name { get; set; }
        public string? WorkCode { get; set; }

        // Navigation Property
        public ICollection<Employee> Employees { get; set; }
    }
}
