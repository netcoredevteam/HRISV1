using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
    }
}
