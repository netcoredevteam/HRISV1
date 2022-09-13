namespace HRIS.WebApi.Models.Request
{
    public class DailyRecordsSearchRequestModel
    {
        public string? EmployeeNo { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
