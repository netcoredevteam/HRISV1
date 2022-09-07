using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Domain.Entities
{
    public class Whitelist : BaseEntity
    {
        public string? Ip { get; set; }
        public string? Remark { get; set; }

    }
}
