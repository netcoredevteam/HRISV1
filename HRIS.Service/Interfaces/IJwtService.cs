﻿using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Service.Interfaces
{
    public interface IJwtService
    {
        string? GenerateToken(User user);
        Guid? ValidateToken(string? token);
    }
}
