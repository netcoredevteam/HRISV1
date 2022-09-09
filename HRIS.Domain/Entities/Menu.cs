using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string? Name { get; set; }
        public string? Page { get; set; }
        public string? Title { get; set; }
        public int? IsShown { get; set; }
        public string? Icon { get; set; }
        public int? Sort { get; set; }

    }
}
