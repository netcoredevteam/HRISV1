namespace HRIS.WebApi.Models.Request
{
    /// <summary>
    /// Create Whitelist Model
    /// </summary>
    public class CreateWhitelistRequestModel
    {
        /// <summary>
        /// Ip
        /// </summary>
        public string? Ip { get; set; }
        /// <summary>
        /// Remarks
        /// </summary>
        public string? Remark { get; set; }
    }
}
