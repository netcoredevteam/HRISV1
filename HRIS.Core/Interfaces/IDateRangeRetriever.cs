using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Core.Interfaces
{
    public interface IDateRangeRetriever<Entity>
    {
        Task<IEnumerable<Entity>> GetByDateRange(DateTime from, DateTime to);
    }
}
