using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.DTOs
{
    public class CreateEmployeeDto
    {
        [JsonProperty(PropertyName = "employee_no")]
        public string? EmployeeNo { get; set; }

        [JsonProperty(PropertyName = "first_name")]
        public string? FirstName { get; set; }

        [JsonProperty(PropertyName = "last_name")]
        public string? LastName { get; set; }

        [JsonProperty(PropertyName = "date_hired")]
        public DateTime DateHired { get; set; }

        [JsonProperty(PropertyName = "birthdate")]
        public DateTime BirthDate { get; set; }
    }
}
