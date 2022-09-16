using HRIS.Domain.Entities;
using HRIS.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HRIS.Repository.Implementations
{
    public class LeaveRecordRepository : BaseRepository, ILeaveRecordRepository
    {
        public LeaveRecordRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(LeaveRecord entity)
        {
            Context.LeaveRecords.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<LeaveRecord>> GetAllAsync()
        {
            return await Context.LeaveRecords.ToListAsync();
        }

        public async Task<LeaveRecord> GetAsync(Guid id)
        {
            return await Context.LeaveRecords.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(LeaveRecord entity)
        {
            Context.LeaveRecords.Add(entity);

            await Context.SaveChangesAsync();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(LeaveRecord entity)
        {
            Context.LeaveRecords.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}
