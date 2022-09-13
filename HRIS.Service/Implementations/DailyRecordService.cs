using AutoMapper;
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
    public class DailyRecordService : IDailyRecordService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IDailyRecordRepository _dailyRecordRepository;
        private readonly IMapper _mapper;

        public DailyRecordService(IEmployeeRepository employeeRepository,
                                  IDailyRecordRepository dailyRecordRepository,
                                  IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _dailyRecordRepository = dailyRecordRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DailyRecordEmployeeDto>> GetNameListAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            var employeesDto = _mapper.Map<List<DailyRecordEmployeeDto>>(employees);

            return employeesDto;
        }

        public async Task<List<DailyRecordDto>> GetRecordsAsync(DailyRecordSearchDto model)
        {
            var employee = await _employeeRepository.GetByEmployeeNoAsync(model.EmployeeNo);

            var records = _dailyRecordRepository.GetAllByEmployeeNoAsync(employee.EmployeeNo);
            var recordsDto = _mapper.Map<List<DailyRecordDto>>(records);

            return recordsDto;
        }
    }
}
