using AutoMapper;

using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Implementations
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;



        public EmployeeService(IEmployeeRepository employeeRepository,
            IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;

        }

        public async Task CreateAsync(Employee employee)
        { 
            await _employeeRepository.InsertAsync(employee);
            await _employeeRepository.SaveChangesAsync();
        }

        public async Task<IEnumerable<EmployeeDto>> GetAllAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            var employeeDto = _mapper.Map<List<EmployeeDto>>(employees);

            return employeeDto;
        }

        public Task<Employee> GetAsync(string employeeNo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HasDuplicateAsync(string employeeNo)
        {
            return await _employeeRepository.HasDuplicateAsync(employeeNo);
        }
    }
}
