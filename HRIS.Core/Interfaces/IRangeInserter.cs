using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Core.Interfaces
{
    public interface IRangeInserter<Entity>
    {
        Task InsertRangeAsync(List<Entity> entities);
    }
}
