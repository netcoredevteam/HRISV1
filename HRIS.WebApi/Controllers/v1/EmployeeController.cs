namespace HRIS.WebApi.Controllers.v1
{
    #region EmployeeController V1
    /// <summary>
    /// Employee Api
    /// </summary>
    [ApiVersion("1.0")]
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeService _employeeService;
        private readonly IMandatoryService _mandatoryService;

        /// <summary>
        /// Employee DI
        /// </summary>
        /// <param name="employeeService"></param>
        /// <param name="mandatoryService"></param>
        public EmployeeController(IEmployeeService employeeService, IMandatoryService mandatoryService)
        {
            _employeeService = employeeService;
            _mandatoryService = mandatoryService;
        }

        #region Get All Employees
        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAllAsync()
        {
            return Ok(await _employeeService.GetAllAsync());
        }

        #endregion

        #region Create Employee
        /// <summary>
        /// Creates an Employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] InsertEmployeeRequestModel model)
        {
            if (model.EmployeeDetails.Count == 0)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            foreach (var employeeDetail in model.EmployeeDetails)
            {
                var hasDuplicate = await _employeeService.HasDuplicateAsync(employeeDetail.EmployeeNo);

                if (!hasDuplicate)
                {
                    var employee = new Employee
                    {
                        EmployeeNo = employeeDetail.EmployeeNo,
                        FirstName = employeeDetail.FirstName,
                        LastName = employeeDetail.LastName,
                        DateHired = Convert.ToDateTime(employeeDetail.DateHired),
                        BirthDate = Convert.ToDateTime(employeeDetail.Birthday),
                        Address = employeeDetail.Address,
                        Phone = employeeDetail.Phone,
                        ContactName = employeeDetail.ContactName,
                        ContactNo = employeeDetail.ContactNo,
                        WorkPositionId = Guid.Empty,
                        IsDeleted = false,
                        CreatedBy = "System",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = "System",
                        ScheduleId = employeeDetail.ScheduleCode
                    };

                    var mandatory = new Mandatory
                    {
                        Id = Guid.NewGuid(),
                        EmployeeId = employee.Id,
                        SSS = employeeDetail.SSS,
                        PagIbig = employeeDetail.PagibigNo,
                        PhilHealth = employeeDetail.PhilHealthNo,
                        TIN = employeeDetail.TinNo,
                        HMO = employeeDetail.HMO,
                        CreatedBy = "System",
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                        UpdatedBy = "System"
                    };

                    employee.MandatoryId = mandatory.Id;
                    await _mandatoryService.CreateAsync(mandatory);
                    await _employeeService.CreateAsync(employee);
                }

            }

            return Ok(ResponseMessage.Success);
        }

        #endregion
    }
    #endregion
}
