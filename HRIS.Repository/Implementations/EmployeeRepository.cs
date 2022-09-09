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
    public class EmployeeRepository : Repository, IEmployeeRepository
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task DeleteAsync(Employee entity)
        {
            Context.Employees.Remove(entity);

            await Context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await Context.Employees.ToListAsync();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return await Context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetByEmployeeNoAsync(string? id)
        {
            return await Context.Employees.FirstOrDefaultAsync(e => e.EmployeeNo == id);
        }

        public async Task InsertAsync(Employee entity)
        {
            Context.Employees.Add(entity);

            await Context.SaveChangesAsync();
        }



        public async Task<bool> IsInUseAsync(Guid id)
        {
            var employee = await Context.Employees.FirstOrDefaultAsync(e => e.Id == id);

            return employee.IsDeleted;
        }

        public async Task UpdateAsync(Employee entity)
        {
            Context.Employees.Update(entity);

            await Context.SaveChangesAsync();
        }


        Task<IEnumerable<Employee>> IListRetriever<Employee>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<Employee> IRetriever<Employee, Guid>.GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IEmployeeRepository.GetByEmployeeNoAsync(string? id)
        {
            throw new NotImplementedException();
        }
    }
}
