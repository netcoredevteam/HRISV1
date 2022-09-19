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
            //var whitelist = _mapper.Map<Whitelist>(model);

            var whitelist = new Whitelist();
            whitelist.Id = model.Id;
            whitelist.Ip = model.Ip;
            whitelist.Remark = model.Remark;
            whitelist.CreatedAt = DateTime.Now;
            whitelist.UpdatedAt = DateTime.Now;

            await _whitelistRepository.InsertAsync(whitelist);
            await _whitelistRepository.SaveChangesAsync();
        }

        public async Task<List<WhitelistDto>> GetAllAsync()
        {
            var whitelist = await _whitelistRepository.GetAllAsync();

            if (!whitelist.Any())
            {
                throw new ListNotFoundException("No whitelist found.");
            }

            //var whitelistDtos = _mapper.Map<List<WhitelistDto>>(whitelist);

            var whitelistDtos = new List<WhitelistDto>();
            foreach (var item in whitelist)
            {
                var whitelistDto = new WhitelistDto();
                whitelistDto.Ip = item.Ip;
                whitelistDto.Remark = item.Remark;
                whitelistDto.Id = item.Id;
            }

            return whitelistDtos;
        }

        public async Task<WhitelistDto> GetAsync(Guid id)
        {
            var whitelist = await _whitelistRepository.GetAsync(id);

            var whitelistDto = new WhitelistDto();
            whitelistDto.Ip = whitelist.Ip;
            whitelistDto.Remark = whitelist.Remark;
            whitelistDto.Id = id;

            //var whitelistDto = _mapper.Map<WhitelistDto>(whitelist);

            return whitelistDto;
        }

        public async Task RemoveAsync(WhitelistDto model)
        {
            //var whitelist = _mapper.Map<Whitelist>(model);

            var whitelist = new Whitelist();
            whitelist.Id = model.Id;
            whitelist.Ip = model.Ip;
            whitelist.Remark = model.Remark;
            whitelist.UpdatedAt = DateTime.Now;

            await _whitelistRepository.DeleteAsync(whitelist);
            await _whitelistRepository.SaveChangesAsync();
        }

        public async Task UpdateAsync(Guid id, WhitelistDto model)
        {
            //var whitelist = _mapper.Map<Whitelist>(model);

            var whitelist = new Whitelist();
            whitelist.Ip = model.Ip;
            whitelist.Remark = model.Remark;
            whitelist.UpdatedAt = DateTime.Now;
            whitelist.Id = id;

            await _whitelistRepository.UpdateAsync(whitelist);
            await _whitelistRepository.SaveChangesAsync();
        }
    }
}
