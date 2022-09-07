using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class DailyRecordRepository : IDailyRecordRepository
    {
        public Task DeleteAsync(Mandatory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Mandatory>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Mandatory> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task InsertAsync(Mandatory entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Mandatory entity)
        {
            throw new NotImplementedException();
        }
    }
}
