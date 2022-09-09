using HRIS.Domain.Entities;
using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task CreateAsync(Employee employee);
        Task<bool> HasDuplicateAsync(string employeeNo);
        Task<Employee> GetAsync(string employeeNo);
    }
}
