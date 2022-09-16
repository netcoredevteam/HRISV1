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
    public class AnnouncementRepository : BaseRepository, IAnnouncementRepository
    {
        public AnnouncementRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Announcement entity)
        {
            Context.Announcements.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Announcement>> GetAllAsync()
        {
            return await Context.Announcements.ToListAsync();
        }

        public async Task<Announcement> GetAsync(Guid id)
        {
            return await Context.Announcements.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(Announcement entity)
        {
            Context.Announcements.Add(entity);

            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Announcement entity)
        {
            Context.Announcements.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}
