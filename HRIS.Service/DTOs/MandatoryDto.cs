using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class MandatoryDto
    {
        public string? EmployeeId { get; set; }
        public string? Sss { get; set; }
        public string? PagIbig { get; set; }
        public string? PhilHealth { get; set; }
        public string? Tin { get; set; }
        public string? Hmo { get; set; }
    }
}
