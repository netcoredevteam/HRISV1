using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Core.Interfaces
{
    public interface IDeleter<Entity>
    {
        Task DeleteAsync(Entity entity);
    }
}
