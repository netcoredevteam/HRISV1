using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task CreateAsync(CreateEmployeeDto model);
    }
}
