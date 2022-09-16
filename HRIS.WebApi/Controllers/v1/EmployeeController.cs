using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using static HRIS.WebApi.Models.RequestModels.Authenticated.Employee.InsertEmployeeRequestModel;
using HRIS.Domain.Entities;

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
        private readonly IWorkPositionService _workPositionService;
        private readonly IScheduleService _scheduleService;

        /// <summary>
        /// Employee DI
        /// </summary>
        /// <param name="employeeService"></param>
        /// <param name="mandatoryService"></param>
        public EmployeeController(
              IEmployeeService employeeService
            , IMandatoryService mandatoryService
            , IWorkPositionService workPositionService
            , IScheduleService scheduleService
            )
        {
            _employeeService = employeeService;
            _mandatoryService = mandatoryService;
            _workPositionService = workPositionService;
            _scheduleService = scheduleService;
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

        #region Get Employee
        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> GetAsync(Guid id)
        {
            var employee = await _employeeService.GetAsync(id);

            if (employee == null)
            {
                return NotFound(ResponseMessage.NotFound);
            }

            return Ok(employee);
        }
        #endregion

        #region Filter Employee
        /// <summary>
        /// Get All Employees
        /// </summary>
        /// <returns></returns>
        [HttpGet("Filter")]
        [AllowAnonymous]
        public async Task<IActionResult> FilterAsync([FromBody] FilterEmployeeRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            var employee = await _employeeService.FilterAsync(model.EmployeeNo, model.Name, model.IsDeleted);

            return Ok(employee);
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
            if (!ModelState.IsValid)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            var hasDuplicate = await _employeeService.HasDuplicateAsync(model.EmployeeNo);

            if (hasDuplicate)
            {
                return Conflict(ResponseMessage.DuplicateEmployeeNo);
            }

            var employee = new Employee();
            employee.Id = Guid.NewGuid();
            employee.EmployeeNo = model.EmployeeNo;
            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.DateHired = Convert.ToDateTime(model.DateHired);
            employee.BirthDate = Convert.ToDateTime(model.Birthday);
            employee.Address = model.Address;
            employee.Phone = model.Phone;
            employee.ContactName = model.ContactName;
            employee.ContactNo = model.ContactNo;
            employee.WorkPositionId = model.WorkPositionId;
            employee.ScheduleId = model.ScheduleId;
            employee.CreatedBy = "System";
            employee.CreatedAt = DateTime.Now;
            employee.UpdatedAt = DateTime.Now;
            employee.UpdatedBy = "System";

            var mandatory = new Mandatory();
            mandatory.Id = Guid.NewGuid();
            mandatory.EmployeeId = employee.Id;
            mandatory.SSS = model.SSS;
            mandatory.PagIbig = model.PagibigNo;
            mandatory.PhilHealth = model.PhilHealthNo;
            mandatory.TIN = model.TinNo;
            mandatory.HMO = model.HMO;
            mandatory.CreatedBy = "System";
            mandatory.CreatedAt = DateTime.Now;
            mandatory.UpdatedAt = DateTime.Now;
            mandatory.UpdatedBy = "System";

            employee.MandatoryId = mandatory.Id;

            await _mandatoryService.CreateAsync(mandatory);
            await _employeeService.CreateAsync(employee);

            return Ok(ResponseMessage.Success);
        }
        #endregion

        #region Update Employee
        /// <summary>
        /// Update Employee
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Guid id, [FromBody] UpdateEmployeeRequestModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            if (id != model.Id)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            var employee = await _employeeService.GetEmployeeAsync(id);

            if (employee == null)
            {
                return NotFound(ResponseMessage.NotFound);
            }

            employee.FirstName = model.FirstName;
            employee.LastName = model.LastName;
            employee.DateHired = Convert.ToDateTime(model.DateHired);
            employee.BirthDate = Convert.ToDateTime(model.Birthday);
            employee.Address = model.Address;
            employee.Phone = model.Phone;
            employee.ContactName = model.ContactName;
            employee.ContactNo = model.ContactNo;
            employee.WorkPositionId = model.WorkPositionId;
            employee.ScheduleId = model.ScheduleId;
            employee.UpdatedAt = DateTime.Now;

            var mandatory = await _mandatoryService.GetAsync(employee.MandatoryId);

            mandatory.SSS = model.SSS;
            mandatory.PagIbig = model.PagibigNo;
            mandatory.PhilHealth = model.PhilHealthNo;
            mandatory.TIN = model.TinNo;
            mandatory.HMO = model.HMO;
            mandatory.UpdatedAt = DateTime.Now;

            await _employeeService.UpdateAsync();

            return Ok(ResponseMessage.Success);
        }
        #endregion

        #region Upload Employees
        /// <summary>
        /// Upload Employees
        /// </summary>
        /// <returns></returns>
        [HttpPost("Upload")]
        [AllowAnonymous]
        public async Task<IActionResult> UploadFileAsync([FromForm] IFormFile file)
        {
            if (file == null)
            {
                return BadRequest(ResponseMessage.BadRequest);
            }

            var extension = Path.GetExtension(file.FileName);
            if (extension != ".csv")
            {
                return StatusCode(415, ResponseMessage.FileNotSupported);
            }

            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                stream.Seek(0, SeekOrigin.Begin);

                using var reader = new StreamReader(stream);

                var cultureInfo = new CultureInfo("en-PH");
                var config = new CsvConfiguration(cultureInfo)
                {
                    HasHeaderRecord = true,
                    MissingFieldFound = null,
                    BadDataFound = null,
                };

                using var csv = new CsvReader(reader, config);

                var employeeRecords = csv.GetRecords<Models.CSVModels.Employee>().ToList();

                var employees = new List<Employee>();

                var mandatories = new List<Mandatory>();

                foreach (var employeeRecord in employeeRecords)
                {
                    var hasDuplicate = await _employeeService.HasDuplicateAsync(employeeRecord.EmployeeNo);

                    if (!hasDuplicate)
                    {
                        var employee = new Employee();
                        employee.Id = Guid.NewGuid();
                        employee.EmployeeNo = employeeRecord.EmployeeNo;
                        employee.FirstName = employeeRecord.FirstName;
                        employee.LastName = employeeRecord.LastName;
                        employee.DateHired = Convert.ToDateTime(employeeRecord.DateHired);
                        employee.BirthDate = Convert.ToDateTime(employeeRecord.Birthday);
                        employee.Address = employeeRecord.Address;
                        employee.Phone = employeeRecord.Phone;
                        employee.ContactName = employeeRecord.ContactName;
                        employee.ContactNo = employeeRecord.ContactNo;
                        employee.WorkPositionId = Guid.Parse(employeeRecord.WorkPositionId);
                        employee.ScheduleId = Guid.Parse(employeeRecord.ScheduleId);
                        employee.CreatedBy = "System";
                        employee.CreatedAt = DateTime.Now;
                        employee.UpdatedAt = DateTime.Now;
                        employee.UpdatedBy = "System";

                        var mandatory = new Mandatory();
                        mandatory.Id = Guid.NewGuid();
                        mandatory.EmployeeId = employee.Id;
                        mandatory.SSS = employeeRecord.SSS;
                        mandatory.PagIbig = employeeRecord.PagibigNo;
                        mandatory.PhilHealth = employeeRecord.PhilHealthNo;
                        mandatory.TIN = employeeRecord.TinNo;
                        mandatory.HMO = employeeRecord.HMO;
                        mandatory.CreatedBy = "System";
                        mandatory.CreatedAt = DateTime.Now;
                        mandatory.UpdatedAt = DateTime.Now;
                        mandatory.UpdatedBy = "System";

                        employee.MandatoryId = mandatory.Id;

                        employees.Add(employee);
                        mandatories.Add(mandatory);
                    }
                }

                await _mandatoryService.CreateRangeAsync(mandatories);
                await _employeeService.CreateRangeAsync(employees);
            }

            return Ok(ResponseMessage.UploadComplete);
        }

        #endregion

        #region Delete Employee
        /// <summary>
        /// Delete Employees
        /// </summary>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [AllowAnonymous]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            var employee = await _employeeService.GetEmployeeAsync(id);

            if (employee == null)
            {
                return NotFound(ResponseMessage.NotFound);
            }

            await _employeeService.DeleteAsync(employee);

            return Ok(ResponseMessage.Success);
        }
        #endregion
    }
    #endregion
}
