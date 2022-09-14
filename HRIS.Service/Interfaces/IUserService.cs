using HRIS.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IUserService
    {
        Task<AuthUserDto> AuthenticateAsync(string? username, string? password);
        Task CreateAsync(UserDto user);
    }
}
