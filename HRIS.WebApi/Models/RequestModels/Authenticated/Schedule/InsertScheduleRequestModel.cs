using System.ComponentModel.DataAnnotations;

namespace HRIS.WebApi.Models.RequestModels.Authenticated.Schedule
{
    /// <summary>
    /// Create new Schedule
    /// </summary>
    public class InsertScheduleRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string? Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int? Status { get; set; }
    }
}
