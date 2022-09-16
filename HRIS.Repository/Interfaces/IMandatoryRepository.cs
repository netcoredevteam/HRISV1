using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IMandatoryRepository : IDeleter<Mandatory>,
                                           IInserter<Mandatory>,
                                           IRangeInserter<Mandatory>,
                                           IListRetriever<Mandatory>,
                                           IRetriever<Mandatory, Guid>,
                                           IUpdater<Mandatory>,
                                            IRepository
    {
        Task<Mandatory> GetByEmployeeIdAsync(Guid? id);

    }
}
