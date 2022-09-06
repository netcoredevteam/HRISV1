using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Schedule : BaseEntity
    {
        public Schedule()
        {
            this.Employees = new Collection<Employee>();
        }

        public string? Name { get; set; }
        public DateTime StartTime{ get; set; }
        public DateTime EndTime{ get; set; }
        public DateTime CreateTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
        public int? Status{ get; set; }


        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}
