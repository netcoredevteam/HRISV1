using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class MandatoryRepository : Repository, IMandatoryRepository
    {
        public MandatoryRepository(ApplicationDbContext context) : base(context)
        {
        }

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

        public async Task InsertAsync(Mandatory entity)
        {
            await Context.Mandatories.AddAsync(entity);
        }

        public Task UpdateAsync(Mandatory entity)
        {
            throw new NotImplementedException();
        }
    }
}
