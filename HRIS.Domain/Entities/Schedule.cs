using System.Collections.ObjectModel;

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
        public int? Status{ get; set; }


        // Navigation Properties
        public ICollection<Employee> Employees { get; set; }
    }
}
