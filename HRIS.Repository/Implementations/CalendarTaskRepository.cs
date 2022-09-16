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
    public class CalendarTaskRepository : BaseRepository, ICalendarTaskRepository
    {
        public CalendarTaskRepository(ApplicationDbContext context): base(context)
        {
        }

        public async Task DeleteAsync(CalendarTask entity)
        {
            Context.CalendarTasks.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<CalendarTask>> GetAllAsync()
        {
            return await Context.CalendarTasks.ToListAsync();
        }

        public async Task<CalendarTask> GetAsync(Guid id)
        {
            return await Context.CalendarTasks.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(CalendarTask entity)
        {
            Context.CalendarTasks.Add(entity);

            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(CalendarTask entity)
        {
            Context.CalendarTasks.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}
