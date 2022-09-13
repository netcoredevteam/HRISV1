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
    public class LeaveRecordRepository : ILeaveRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public LeaveRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(LeaveRecord entity)
        {
            _context.LeaveRecords.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LeaveRecord>> GetAllAsync()
        {
            return await _context.LeaveRecords.ToListAsync();
        }

        public async Task<LeaveRecord> GetAsync(Guid id)
        {
            return await _context.LeaveRecords.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(LeaveRecord entity)
        {
            _context.LeaveRecords.Add(entity);

            await _context.SaveChangesAsync();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(LeaveRecord entity)
        {
            _context.LeaveRecords.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
