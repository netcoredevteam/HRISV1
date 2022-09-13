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
    public class CalendarTaskRepository : ICalendarTaskRepository
    {
        private readonly ApplicationDbContext _context;
        public CalendarTaskRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(CalendarTask entity)
        {
            _context.CalendarTasks.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CalendarTask>> GetAllAsync()
        {
            return await _context.CalendarTasks.ToListAsync();
        }

        public async Task<CalendarTask> GetAsync(Guid id)
        {
            return await _context.CalendarTasks.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(CalendarTask entity)
        {
            _context.CalendarTasks.Add(entity);

            await _context.SaveChangesAsync();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(CalendarTask entity)
        {
            _context.CalendarTasks.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
