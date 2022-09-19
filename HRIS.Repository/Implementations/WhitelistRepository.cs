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
    public class WhitelistRepository : BaseRepository, IWhitelistRepository
    {
        public WhitelistRepository(ApplicationDbContext context) : base(context)
        { }

        public async Task DeleteAsync(Whitelist entity)
        {
            entity.IsDelete = true;
        }

        public async Task<IEnumerable<Whitelist>> GetAllAsync()
        {
            return await Context.Whitelists.ToListAsync();
        }

        public async Task<Whitelist> GetAsync(Guid id)
        {
            return await Context.Whitelists.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(Whitelist entity)
        {
            await Context.Whitelists.AddAsync(entity);
        }

        public async Task UpdateAsync(Whitelist entity)
        {
            Context.Whitelists.Update(entity);
        }
    }
}
