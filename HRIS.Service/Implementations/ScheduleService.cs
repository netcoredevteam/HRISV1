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
    public class ScheduleService : IScheduleService
    {
        private readonly IScheduleRepository _scheduleRepository;
        private readonly IMapper _mapper;

        public ScheduleService(IScheduleRepository scheduleRepository,
            IMapper mapper)
        {
            _scheduleRepository = scheduleRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ScheduleDto>> GetAllAsync()
        {
            var mandatories = await _scheduleRepository.GetAllAsync();
            var scheduleDto = _mapper.Map<List<ScheduleDto>>(mandatories);

            return scheduleDto;
        }

        public async Task<Guid> GetidAsync(string? scheduleName)
        {
            return await _scheduleRepository.GetIdAsync(scheduleName);
        }
    }
}
