using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class WhitelistDto
    {
        public Guid Id { get; set; }
        public string? Ip { get; set; }
        public string? Remark { get; set; }
    }
}
