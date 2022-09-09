using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Announcement : BaseEntity
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
    }
}
