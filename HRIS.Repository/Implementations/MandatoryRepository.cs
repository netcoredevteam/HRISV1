using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;

using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class MandatoryRepository : BaseRepository, IMandatoryRepository
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

        public async Task<Mandatory> GetAsync(Guid id)
        {
            return await Context.Mandatories.SingleOrDefaultAsync(m => m.Id == id);
        }

        public async Task InsertAsync(Mandatory entity)
        {
            await Context.Mandatories.AddAsync(entity);
        }

        public async Task InsertRangeAsync(List<Mandatory> entities)
        {
            await Context.AddRangeAsync(entities);
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public Task UpdateAsync(Mandatory entity)
        {
            throw new NotImplementedException();
        }
    }
}
