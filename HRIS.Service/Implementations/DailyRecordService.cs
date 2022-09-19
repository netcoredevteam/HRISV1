using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Exceptions;
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

        public async Task<IEnumerable<EmployeeNameDto>> GetNameListAsync()
        {
            var employees = await _employeeRepository.GetAllAsync();
            var employeesDto = _mapper.Map<List<EmployeeNameDto>>(employees);

            return employeesDto;
        }

        public async Task<List<DailyRecordDto>> SearchAsync(DailyRecordSearchDto model)
        {
            var employee = await _employeeRepository.GetByEmployeeNoAsync(model.EmployeeNo);

            if (employee == null)
                throw new EmployeeNotFoundException("Employee doesn't exist.");

            var records = await _dailyRecordRepository.GetAllByEmployeeNoAsync(employee.EmployeeNo);

            if (!records.Any())
                throw new ListNotFoundException("No records found.");

            //var recordsDto = _mapper.Map<List<DailyRecordDto>>(records);

            var recordsDto = new List<DailyRecordDto>();
            foreach (var record in records)
            {
                var recordDto = new DailyRecordDto();
                recordDto.Id = record.Id;
                recordDto.TimeIn = record.TimeIn;
                recordDto.TimeOut = record.TimeOut;
                recordDto.LunchIn = record.LunchIn;
                recordDto.LunchOut = record.LunchOut;
                recordDto.OTIn = record.OTIn;
                recordDto.OTOut = record.OTOut;
            }

            return recordsDto;
        }

        public async Task CreateAsync(DailyRecordDto model)
        {
            //var dailyRecord = _mapper.Map<DailyRecord>(model);

            var dailyRecord = new DailyRecord();
            dailyRecord.Id = model.Id;
            dailyRecord.TimeIn = model.TimeIn;
            dailyRecord.TimeOut = model.TimeOut;
            dailyRecord.LunchIn = model.LunchIn;
            dailyRecord.LunchOut = model.LunchOut;
            dailyRecord.OTIn = model.OTIn;
            dailyRecord.OTOut = model.OTOut;
            dailyRecord.CreatedAt = DateTime.Now;
            dailyRecord.UpdatedAt = DateTime.Now;

            await _dailyRecordRepository.InsertAsync(dailyRecord);
            await _dailyRecordRepository.SaveChangesAsync();
        }

        public async Task RemoveAsync(DailyRecordDto model)
        {
            //var dailyRecord = _mapper.Map<DailyRecord>(model);

            var dailyRecord = new DailyRecord();
            dailyRecord.Id = model.Id;
            dailyRecord.TimeIn = model.TimeIn;
            dailyRecord.TimeOut = model.TimeOut;
            dailyRecord.LunchIn = model.LunchIn;
            dailyRecord.LunchOut = model.LunchOut;
            dailyRecord.OTIn = model.OTIn;
            dailyRecord.OTOut = model.OTOut;
            dailyRecord.CreatedAt = DateTime.Now;
            dailyRecord.UpdatedAt = DateTime.Now;

            await _dailyRecordRepository.DeleteAsync(dailyRecord);
            await _dailyRecordRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(DailyRecordDto model)
        {
            // var dailyRecord = _mapper.Map<DailyRecord>(model);

            var dailyRecord = new DailyRecord();
            dailyRecord.Id = model.Id;
            dailyRecord.TimeIn = model.TimeIn;
            dailyRecord.TimeOut = model.TimeOut;
            dailyRecord.LunchIn = model.LunchIn;
            dailyRecord.LunchOut = model.LunchOut;
            dailyRecord.OTIn = model.OTIn;
            dailyRecord.OTOut = model.OTOut;
            dailyRecord.UpdatedAt = DateTime.Now;

            await _dailyRecordRepository.UpdateAsync(dailyRecord);
            await _dailyRecordRepository.SaveChangesAsync();
        }

        public async Task<DailyRecordDto> GetAsync(Guid id)
        {
            var dailyRecord = await _dailyRecordRepository.GetAsync(id);

            //var dailyRecordDto = _mapper.Map<DailyRecordDto>(dailyRecord);

            var dailyRecordDto = new DailyRecordDto();
            dailyRecordDto.Id = dailyRecord.Id;
            dailyRecordDto.TimeIn = dailyRecord.TimeIn;
            dailyRecordDto.TimeOut = dailyRecord.TimeOut;
            dailyRecordDto.LunchIn = dailyRecord.LunchIn;
            dailyRecordDto.LunchOut = dailyRecord.LunchOut;
            dailyRecordDto.OTIn = dailyRecord.OTIn;
            dailyRecordDto.OTOut = dailyRecord.OTOut;

            return dailyRecordDto;
        }
    }
}
