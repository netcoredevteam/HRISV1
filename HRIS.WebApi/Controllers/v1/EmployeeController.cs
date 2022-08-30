using HRIS.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HRIS.WebApi.Controllers.v1
{
    public class EmployeeController : BaseApiController
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IActionResult> GetAll()
        {
            return Ok(await _employeeService.GetAllEmployees());
        }
    }
}
