﻿using AutoMapper;
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

        public async Task<List<DailyRecordDto>> GetAsync(DailyRecordSearchDto model)
        {
            var employee = await _employeeRepository.GetByEmployeeNoAsync(model.EmployeeNo);

            var records = _dailyRecordRepository.GetAllByEmployeeNoAsync(employee.EmployeeNo);
            var recordsDto = _mapper.Map<List<DailyRecordDto>>(records);

            return recordsDto;
        }

        public async Task CreateAsync(DailyRecordDto model)
        {
            var dailyRecord = _mapper.Map<DailyRecord>(model);
            await _dailyRecordRepository.InsertAsync(dailyRecord);
            await _dailyRecordRepository.SaveChangesAsync();
        }

        public async Task RemoveAsync(Guid id)
        {
            var record = await _dailyRecordRepository.GetAsync(id);
            await _dailyRecordRepository.DeleteAsync(record);
            await _dailyRecordRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(DailyRecordDto model)
        {
            var dailyRecord = _mapper.Map<DailyRecord>(model);
            await _dailyRecordRepository.UpdateAsync(dailyRecord);
            await _dailyRecordRepository.SaveChangesAsync();
        }
    }
}
