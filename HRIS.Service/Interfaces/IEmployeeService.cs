using HRIS.Service.DTOs;

namespace HRIS.Service.Interfaces
{
    public interface IEmployeeService
    {
        Task<IEnumerable<EmployeeDto>> GetAll();
        Task Create(CreateEmployeeDto model);
    }
}
