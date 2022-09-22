using AutoMapper;
using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using HRIS.Service.DTOs;
using HRIS.Service.Exceptions;
using HRIS.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Implementations
{
    public class UserService : IUserService
    {
        private readonly IDistributedCacheRepository<string> _distributedCacheRepository;
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;

        public UserService(IUserRepository userRepository,
            IJwtService jwtService,
            IDistributedCacheRepository<string> distributedCacheRepository)
        {
            _distributedCacheRepository = distributedCacheRepository;
            _userRepository = userRepository;
            _jwtService = jwtService;
        }

        public async Task<AuthUserDto> AuthenticateAsync(string? username, string? password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            // Validate
            if (user == null || password != user.Password)
                throw new UserNotFoundException("Username or Password is incorrect.");

            var userEmployeeDto = new UserEmployeeDto();
            userEmployeeDto.FirstName = user.Employee?.FirstName;
            userEmployeeDto.LastName = user.Employee?.LastName;
            userEmployeeDto.Username = user.Username;
            userEmployeeDto.EmployeeNo = user.Employee?.EmployeeNo;
            userEmployeeDto.Role = user.Role;

            // Authentication Successful
            var token = _jwtService.GenerateToken(user);

            await _distributedCacheRepository.SetCacheAsync(user.Id.ToString(), token, TimeSpan.FromDays(5));

            var response = new AuthUserDto(userEmployeeDto, token);

            return response;
        }

        public async Task CreateAsync(UserDto userDto)
        {
            var user = new User();
            user.Username = userDto.Username;
            user.Nickname = userDto.Nickname;
            user.Password = userDto.Password;
            user.Role = userDto.Role;
            user.EmployeeId = userDto.EmployeeId;
            user.ProfileImage = userDto.ProfileImage;
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;

            await _userRepository.InsertAsync(user);
            await _userRepository.SaveChangesAsync();
        }
    }
}
