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
    public class WorkPositionService : IWorkPositionService
    {
        private readonly IWorkPositionRepository _workPositionRepository;
        private readonly IMapper _mapper;

        public WorkPositionService(IWorkPositionRepository workPositionRepository,
            IMapper mapper)
        {
            _workPositionRepository = workPositionRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<WorkPositionDto>> GetAllAsync()
        {
            var workPositions = await _workPositionRepository.GetAllAsync();
            var workPositionDto = _mapper.Map<List<WorkPositionDto>>(workPositions);

            return workPositionDto;
        }

        public async Task<Guid> GetIdAsync(string workCode)
        {
            return await _workPositionRepository.GetIdAsync(workCode);
        }
    }
}
