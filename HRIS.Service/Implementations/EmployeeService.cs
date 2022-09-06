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

        public async Task Create(CreateEmployeeDto model)
        {
            var employee = _mapper.Map<Employee>(model);
            await _employeeRepository.Insert(employee);
        }

        public async Task<IEnumerable<EmployeeDto>> GetAll()
        {
            var employees = await _employeeRepository.GetAll();
            var employeeDto = _mapper.Map<List<EmployeeDto>>(employees);

            return employeeDto;
        }
    }
}
