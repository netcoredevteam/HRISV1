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
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IJwtService _jwtService;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, 
            IEmployeeRepository employeeRepository,
            IJwtService jwtService,
            IMapper mapper)
        {
            _userRepository = userRepository;
            _employeeRepository = employeeRepository;
            _jwtService = jwtService;
            _mapper = mapper;
        }

        public async Task<AuthUserDto> AuthenticateUser(string? username, string? password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            // Validate
            if (user == null || password != user.Password)
                throw new ApplicationException("Username or password is incorrect");

            var userEmployee = _mapper.Map<UserEmployeeDto>(user);

            // Authentication Successful
            var token = _jwtService.GenerateToken(user);
            var response = new AuthUserDto(userEmployee, token);

            return response;
        }
    }
}
