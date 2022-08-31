using HRIS.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

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

        /// <summary>
        /// Employee DI
        /// </summary>
        /// <param name="employeeService"></param>
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        #region Get All Employees
        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }

        #endregion
    }
    #endregion
}
