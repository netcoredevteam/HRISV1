namespace HRIS.WebApi.Models.Request
{
    /// <summary>
    /// Date Range Request Model
    /// </summary>
    public class DateRangeSearchRequestModel
    {
        /// <summary>
        /// Date from
        /// </summary>
        public DateTime From { get; set; }

        /// <summary>
        /// Date to
        /// </summary>
        public DateTime To { get; set; }
    }
}
