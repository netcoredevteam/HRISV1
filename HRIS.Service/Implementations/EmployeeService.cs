using AutoMapper;

using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Interfaces;
using HRIS.Utility.Helpers;

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
            var employeesDtos = new List<EmployeeDto>();

            try
            {
                var employees = await _employeeRepository.GetAllAsync();


                foreach (var employee in employees)
                {

                    var employeeDto = new EmployeeDto()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        TimeSchedule = $"{DateTimeHelper.GetTimeFormat(employee.Schedule.StartTime)} - {DateTimeHelper.GetTimeFormat(employee.Schedule.EndTime)}",
                        DateHired = DateTimeHelper.GetDateFormat(employee.DateHired),
                        BirthDate = DateTimeHelper.GetDateFormat(employee.BirthDate),
                        Address = employee.Address,
                        Phone = employee.Phone,
                        HMO = employee.Mandatory?.HMO,
                        TinNo = employee.Mandatory?.TIN,
                        SSS = employee.Mandatory?.SSS,
                        PagIbigNo = employee.Mandatory?.PagIbig,
                        PhilHealthNo = employee.Mandatory?.PhilHealth,
                        Status = !employee.IsDeleted ? "Active" : "Deleted"
                    };

                    employeesDtos.Add(employeeDto);
                }
            }
            catch (Exception ex)
            {
                throw;
            }

            return employeesDtos;
        }

        public async Task<EmployeeDto> GetAsync(Guid id)
        {
            var employee = await _employeeRepository.GetAsync(id);

            var employeeDto = new EmployeeDto()
            {
                Id = employee.Id,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                TimeSchedule = $"{DateTimeHelper.GetTimeFormat(employee.Schedule.StartTime)} - {DateTimeHelper.GetTimeFormat(employee.Schedule.EndTime)}",
                DateHired = DateTimeHelper.GetDateFormat(employee.DateHired),
                BirthDate = DateTimeHelper.GetDateFormat(employee.BirthDate),
                Address = employee.Address,
                Phone = employee.Phone,
                HMO = employee.Mandatory?.HMO,
                TinNo = employee.Mandatory?.TIN,
                SSS = employee.Mandatory?.SSS,
                PagIbigNo = employee.Mandatory?.PagIbig,
                PhilHealthNo = employee.Mandatory?.PhilHealth,
                Status = !employee.IsDeleted ? "Active" : "Deleted"
            };

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

        public async Task CreateRangeAsync(List<Employee> employees)
        {
            await _employeeRepository.InsertRangeAsync(employees);
            await _employeeRepository.SaveChangesAsync();
        }


        public Task<EmployeeDto> GetAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Employee> GetEmployeeAsync(Guid id)
        {
            return await _employeeRepository.GetAsync(id);
        }

        public async Task UpdateAsync()
        {
            await _employeeRepository.SaveChangesAsync();
        }

        public async Task<List<EmployeeDto>> FilterAsync(string employeeNo, string name, bool isDeleted)
        {
            var employeesDtos = new List<EmployeeDto>();
            try
            {
                var employees = await _employeeRepository.FilterAsync(employeeNo, name, isDeleted);
                
                foreach (var employee in employees)
                {
                    var employeeDto = new EmployeeDto()
                    {
                        Id = employee.Id,
                        FirstName = employee.FirstName,
                        LastName = employee.LastName,
                        TimeSchedule = $"{DateTimeHelper.GetTimeFormat(employee.Schedule.StartTime)} - {DateTimeHelper.GetTimeFormat(employee.Schedule.EndTime)}",
                        DateHired = DateTimeHelper.GetDateFormat(employee.DateHired),
                        BirthDate = DateTimeHelper.GetDateFormat(employee.BirthDate),
                        Address = employee.Address,
                        Phone = employee.Phone,
                        HMO = employee.Mandatory?.HMO,
                        TinNo = employee.Mandatory?.TIN,
                        SSS = employee.Mandatory?.SSS,
                        PagIbigNo = employee.Mandatory?.PagIbig,
                        PhilHealthNo = employee.Mandatory?.PhilHealth,
                        Status = !employee.IsDeleted ? "Active" : "Deleted"
                    };

                    employeesDtos.Add(employeeDto);
                }
            }
            catch (Exception)
            {
                throw;
            }

            return employeesDtos;
          
        }

        public async Task DeleteAsync(Employee employee)
        {
            await _employeeRepository.DeleteAsync(employee);
            await _employeeRepository.SaveChangesAsync();
        }
    }
}
