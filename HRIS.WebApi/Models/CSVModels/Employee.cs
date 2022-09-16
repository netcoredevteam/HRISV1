using CsvHelper.Configuration.Attributes;

namespace HRIS.WebApi.Models.CSVModels
{
    /// <summary>
    /// Employee CSV
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Index(0)]
        public string? EmployeeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        [Index(1)]
        public string? FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(2)]
        public string? LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(3)]
        public string? DateHired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(4)]
        public string? ScheduleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(5)]
        public string? Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(6)]
        public string? Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(7)]
        public string? Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(8)]
        public string? ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(9)]
        public string? ContactNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(10)]
        public string? TinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(11)]
        public string? SSS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(12)]
        public string? PagibigNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(13)]
        public string? PhilHealthNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(14)]
        public string? HMO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Index(15)]
        public string? WorkPositionId{ get; set; }
    }
}
