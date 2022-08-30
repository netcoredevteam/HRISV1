using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAllEmployees();
    }
}
