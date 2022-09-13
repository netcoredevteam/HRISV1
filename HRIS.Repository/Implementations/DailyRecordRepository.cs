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
    public class DailyRecordRepository : IDailyRecordRepository
    {
        private readonly ApplicationDbContext _context;

        public DailyRecordRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(DailyRecord entity)
        {
            _context.DailyRecords.Remove(entity);
        }

        public async Task<IEnumerable<DailyRecord>> GetAllAsync()
        {
            return await _context.DailyRecords.ToListAsync();
        }

        public async Task<IEnumerable<DailyRecord>> GetAllByEmployeeNoAsync(string? employeeNo)
        {
            throw new NotImplementedException();
        }

        public async Task<DailyRecord> GetAsync(Guid id)
        {
            return await _context.DailyRecords.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task InsertAsync(DailyRecord entity)
        {
            await _context.DailyRecords.AddAsync(entity);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DailyRecord entity)
        {
            _context.DailyRecords.Update(entity);
        }
    }
}
