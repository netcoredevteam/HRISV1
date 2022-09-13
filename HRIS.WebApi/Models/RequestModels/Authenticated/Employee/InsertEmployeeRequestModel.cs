using HRIS.Domain.Enums;

namespace HRIS.WebApi.Models.RequestModels.Authenticated.Employee
{
    /// <summary>
    /// Insert employees and their mandatories  
    /// </summary>
    public class InsertEmployeeRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        public InsertEmployeeRequestModel()
        {
            EmployeeDetails = new Collection<EmployeeDetail>();
        }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<EmployeeDetail> EmployeeDetails { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public partial class EmployeeDetail
        {
            /// <summary>
            /// 
            /// </summary>
            public string? EmployeeNo { get; set; }
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
            public string? Schedule { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string? Birthday { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string? Phone { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string? Address { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string? ContactName { get; set; }
            /// <summary>
            /// 
            /// </summary>
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
            public string? WorkPositionCode { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Guid ScheduleCode { get; set; }

        }

    }



}
