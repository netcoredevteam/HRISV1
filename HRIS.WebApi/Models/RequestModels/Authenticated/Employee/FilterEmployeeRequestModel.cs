namespace HRIS.WebApi.Models.RequestModels.Authenticated.Employee
{
    /// <summary>
    /// 
    /// </summary>
    public class FilterEmployeeRequestModel
    {/// <summary>
    /// 
    /// </summary>
        public string? EmployeeNo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsDeleted { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Name { get; set; }
    }
}
