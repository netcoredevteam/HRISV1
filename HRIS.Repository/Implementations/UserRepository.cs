using HRIS.Domain.Entities;
using HRIS.Domain.Enums;
using HRIS.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ApplicationDbContext context) : base(context)
        { }

        public async Task DeleteAsync(User entity)
        {
            Context.Users.Remove(entity);
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await Context.Users.ToListAsync();
        }

        public async Task<User> GetAsync(Guid id)
        {
            return await Context.Users
                .Include(u => u.Employee)
                .SingleOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetByEmployeeIdAsync(Guid id)
        {
            return await Context.Users.FirstOrDefaultAsync(u => u.EmployeeId == id);
        }

        public async Task<User> GetByUsernameAsync(string? username)
        {
            return await Context.Users
                .Include(u => u.Employee)
                .FirstOrDefaultAsync(u => u.Username == username);
        }

        public async Task InsertAsync(User entity)
        {
            await Context.Users.AddAsync(entity);
        }

        public async Task<bool> IsInUseAsync(Guid id)
        {
            var user = await Context.Users.FirstOrDefaultAsync(u => u.Id == id);

            return user.Status == Status.Active;
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User entity)
        {
            Context.Users.Update(entity);
        }
    }
}
