namespace HRIS.Service.DTOs
{
    public class ProfileDto
    {
        public string? EmployeeNo { get; set; }
        public string? Username { get; set; }
        public DateTime DateHired { get; set; }
        public int? YearsOfService { get; set; }

        //ProfileInfo
        public DateTime? Birthday { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? ContactName { get; set; }
        public string? ContactNo { get; set; }

        //PH Mandatory
        public string? Sss { get; set; }
        public string? PagIbig { get; set; }
        public string? PhilHealth { get; set; }
        public string? Tin { get; set; }
        public string? Hmo { get; set; }


    }
}
