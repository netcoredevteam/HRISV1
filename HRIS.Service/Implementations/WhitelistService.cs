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
    public class WhitelistService : IWhitelistService
    {
        private readonly IWhitelistRepository _whitelistRepository;
        private readonly IMapper _mapper;

        public WhitelistService(IWhitelistRepository whitelistRepository,
            IMapper mapper)
        {
            _whitelistRepository = whitelistRepository;
            _mapper = mapper;
        }

        public async Task CreateAsync(WhitelistDto model)
        {
            var whiltelistDto = _mapper.Map<Whitelist>(model);
            await _whitelistRepository.InsertAsync(whiltelistDto);
            await _whitelistRepository.SaveChangesAsync();
        }

        public async Task<List<WhitelistDto>> GetAllAsync()
        {
            var whitelist = await _whitelistRepository.GetAllAsync();
            var whitelistDtos = _mapper.Map<List<WhitelistDto>>(whitelist);
            return whitelistDtos;
        }

        public async Task RemoveAsync(Guid id)
        {
            var whitelist = await _whitelistRepository.GetAsync(id);
            await _whitelistRepository.DeleteAsync(whitelist);
            await _whitelistRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(WhitelistDto model)
        {
            var whiltelistDto = _mapper.Map<Whitelist>(model);
            await _whitelistRepository.UpdateAsync(whiltelistDto);
            await _whitelistRepository.SaveChangesAsync();
        }
    }
}
