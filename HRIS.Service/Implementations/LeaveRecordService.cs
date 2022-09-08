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
    public class LeaveRecordService : ILeaveRecordService
    {
        private readonly ILeaveRecordRepository _leaveRecordRepository;
        private readonly IMapper _mapper;

        public LeaveRecordService(ILeaveRecordRepository leaveRecordRepository,
            IMapper mapper)
        {
            _leaveRecordRepository = leaveRecordRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<LeaveRecordDto>> GetAllAsync()
        {
            var mandatories = await _leaveRecordRepository.GetAllAsync();
            var leaveRecordDto = _mapper.Map<List<LeaveRecordDto>>(mandatories);

            return leaveRecordDto;
        }
    }
}
