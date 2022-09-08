using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IEmployeeRepository : IDeleter<Employee>, 
                                           IInserter<Employee>, 
                                           IListRetriever<Employee>, 
                                           IRetriever<Employee, Guid>, 
                                           IUpdater<Employee>,
                                           IInUseChecker<Guid>
    {
        Task<Employee> GetByEmployeeIdAsync(string? id);
    }
}
