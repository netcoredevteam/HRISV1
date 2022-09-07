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
    public class AnnouncementRepository : IAnnouncementRepository
    {
        private readonly ApplicationDbContext _context;

        public AnnouncementRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task DeleteAsync(Announcement entity)
        {
            _context.Announcements.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Announcement>> GetAllAsync()
        {
            return await _context.Announcements.ToListAsync();
        }

        public async Task<Announcement> GetAsync(Guid id)
        {
            return await _context.Announcements.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task InsertAsync(Announcement entity)
        {
            _context.Announcements.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Announcement entity)
        {
            _context.Announcements.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
