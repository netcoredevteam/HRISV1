using HRIS.Core.Interfaces;
using HRIS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Interfaces
{
    public interface IWhitelistRepository : IDeleter<Whitelist>,
                                            IInserter<Whitelist>,
                                            IListRetriever<Whitelist>,
                                            IRetriever<Whitelist, Guid>,
                                            IUpdater<Whitelist>,
                                            ISaver
    { }
}
