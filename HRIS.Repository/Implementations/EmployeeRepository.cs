using HRIS.Core.Interfaces;
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
    public class EmployeeRepository : BaseRepository, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Employee entity)
        {
            Context.Employees.Remove(entity);
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await Context.Employees
                .Include(e => e.Mandatory)
                .Include(e => e.WorkPosition)
                .Include(e => e.Schedule)
                .ToListAsync();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return await Context.Employees
                .Include(e => e.Mandatory)
                .Include(e => e.WorkPosition)
                .Include(e => e.Schedule)
                .SingleOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetByEmployeeNoAsync(string? id)
        {
            return await Context.Employees.SingleOrDefaultAsync(e => e.EmployeeNo == id);
        }

        public async Task<bool> HasDuplicateAsync(string employeeNo)
        {
            return await Context.Employees.Where(e => e.EmployeeNo == employeeNo).AnyAsync();
        }

        public async Task InsertAsync(Employee entity)
        {
            await Context.Employees.AddAsync(entity);
        }

        public async Task<bool> IsInUseAsync(Guid id)
        {
            var employee = await Context.Employees.SingleOrDefaultAsync(e => e.Id == id);

            return employee.IsDeleted;
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateAsync(Employee entity)
        {
            Context.Employees.Update(entity);

            await Context.SaveChangesAsync();
        }
    }
}
