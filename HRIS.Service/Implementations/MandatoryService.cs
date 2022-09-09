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
    public class MandatoryService : IMandatoryService
    {
        private readonly IMandatoryRepository _mandatoryRepository;
        private readonly IMapper _mapper;

        public MandatoryService(IMandatoryRepository mandatoryRepository,
            IMapper mapper)
        {
            _mandatoryRepository = mandatoryRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(Mandatory mandatory)
        {
             await _mandatoryRepository.InsertAsync(mandatory);
        }

        public async Task<IEnumerable<MandatoryDto>> GetAllAsync()
        {
            var mandatories = await _mandatoryRepository.GetAllAsync();
            var mandatoryDto = _mapper.Map<List<MandatoryDto>>(mandatories);

            return mandatoryDto;
        }
    }
}
