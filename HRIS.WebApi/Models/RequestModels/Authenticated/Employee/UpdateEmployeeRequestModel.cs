using System.ComponentModel.DataAnnotations;

namespace HRIS.WebApi.Models.RequestModels.Authenticated.Employee
{
    public class UpdateEmployeeRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? DateHired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Birthday { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(11)]
        public string? Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(150)]
        public string? Address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? ContactName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [MaxLength(11)]
        public string? ContactNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? TinNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? SSS { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? PagibigNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? PhilHealthNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? HMO { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid WorkPositionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public Guid ScheduleId { get; set; }
    }
}
