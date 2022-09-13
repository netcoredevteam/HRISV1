using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IUserRepository : IDeleter<User>,
                                       IInserter<User>,
                                       IListRetriever<User>,
                                       IRetriever<User, Guid>,
                                       IUpdater<User>,
                                       IInUseChecker<Guid>,
                                       ISaver
    {
        Task<User> GetByEmployeeIdAsync(Guid id);
        Task<User> GetByUsernameAsync(string? username);
    }
}
