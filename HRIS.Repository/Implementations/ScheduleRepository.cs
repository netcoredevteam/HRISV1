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
    public class ScheduleRepository : IScheduleRepository
    {
        private readonly ApplicationDbContext _context;

        public ScheduleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(Schedule entity)
        {
            _context.Schedules.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await _context.Schedules.ToListAsync();
        }

        public async Task<Schedule> GetAsync(Guid id)
        {
            return await _context.Schedules.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(Schedule entity)
        {
            _context.Schedules.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Schedule entity)
        {
            _context.Schedules.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
