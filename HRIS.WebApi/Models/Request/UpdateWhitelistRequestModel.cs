namespace HRIS.WebApi.Models.Request
{
    /// <summary>
    /// Update Whitelist Model
    /// </summary>
    public class UpdateWhitelistRequestModel
    {
        /// <summary>
        /// Id
        /// </summary>
        public Guid Id { get; set; }
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
