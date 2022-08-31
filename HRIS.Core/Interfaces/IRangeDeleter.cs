using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Core.Interfaces
{
    internal interface IRangeDeleter<Entity>
    {
        Task DeleteRangeAsync(List<Entity> entities);
    }
}
