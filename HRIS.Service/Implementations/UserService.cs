﻿using AutoMapper;
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
        private readonly IUserRepository _userRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository,
            IJwtService jwtService,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _jwtService = jwtService;
            _mapper = mapper;;
        }

        public async Task<AuthUserDto> AuthenticateAsync(string? username, string? password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            // Validate
            if (user == null || password != user.Password)
                throw new UserNotFoundException("Username or Password is incorrect.");

            var userEmployee = _mapper.Map<UserEmployeeDto>(user);

            // Authentication Successful
            var token = _jwtService.GenerateToken(user);
            var response = new AuthUserDto(userEmployee, token);

            return response;
        }

        public async Task CreateAsync(UserDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.CreatedAt = DateTime.Now;
            user.UpdatedAt = DateTime.Now;

            await _userRepository.InsertAsync(user);
            await _userRepository.SaveChangesAsync();
        }
    }
}
