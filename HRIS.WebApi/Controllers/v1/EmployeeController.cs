using HRIS.Service.DTOs;
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
            return Ok(await _employeeService.GetAllAsync());
        }

        #endregion

        #region Create Employee
        /// <summary>
        /// Creates an Employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateEmployeeDto model)
        {
            await _employeeService.CreateAsync(model);

            return Ok();
        }

        #endregion
    }
    #endregion
}
