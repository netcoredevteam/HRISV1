namespace HRIS.WebApi.Models.Request
{
    public class DailyRecordsRequestModel
    {
        public string? EmployeeNo { get; set; }
        public DateTime? TimeIn { get; set; }
        public DateTime? TimeOut { get; set; }
        public DateTime? LunchIn { get; set; }
        public DateTime? LunchOut { get; set; }
        public DateTime? OTIn { get; set; }
        public DateTime? OTOut { get; set; }
    }
}
