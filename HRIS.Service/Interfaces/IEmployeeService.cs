using HRIS.Domain.Entities;
using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<EmployeeDto> GetAsync(Guid id);
        Task<Employee> GetEmployeeAsync(Guid id);
        Task<IEnumerable<EmployeeDto>> GetAllAsync();
        Task CreateAsync(Employee employee);
        Task<bool> HasDuplicateAsync(string employeeNo);
        Task<Employee> GetAsync(string employeeNo);
        Task<EmployeeDto> GetAsync();
        Task CreateRangeAsync(List<Employee> employees);
        Task UpdateAsync();
        Task<List<EmployeeDto>> FilterAsync(string employeeNo, string name, bool isDeleted); 
        Task DeleteAsync(Employee employee); 

    }
}
