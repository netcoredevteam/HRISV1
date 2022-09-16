using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repository.Implementations
{
    public class ScheduleRepository : BaseRepository, IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Schedule entity)
        {
            Context.Schedules.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Schedule>> GetAllAsync()
        {
            return await Context.Schedules.ToListAsync();
        }

        public async Task<Schedule> GetAsync(Guid id)
        {
            return await Context.Schedules.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Guid> GetIdAsync(string? scheduleName)
        {
            return await Context.Schedules.Where(s => s.Name == scheduleName).Select(s => s.Id).SingleOrDefaultAsync();
        }

        public async Task InsertAsync(Schedule entity)
        {
            Context.Schedules.Add(entity);

            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Schedule entity)
        {
            Context.Schedules.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}
