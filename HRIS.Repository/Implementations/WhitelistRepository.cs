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
    public class WhitelistRepository : IWhitelistRepository
    {
        private readonly ApplicationDbContext _context;

        public WhitelistRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(Whitelist entity)
        {
            _context.Whitelists.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Whitelist>> GetAllAsync()
        {
            return await _context.Whitelists.ToListAsync();
        }

        public async Task<Whitelist> GetAsync(Guid id)
        {
            return await _context.Whitelists.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(Whitelist entity)
        {
            _context.Whitelists.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Whitelist entity)
        {
            _context.Whitelists.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
