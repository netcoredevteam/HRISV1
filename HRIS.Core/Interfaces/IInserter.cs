using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Core.Interfaces
{
    internal interface IInserter<Entity>
    {
        Task InsertAsync(Entity entity);
    }
}
