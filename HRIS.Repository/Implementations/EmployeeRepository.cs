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
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext _context;

        public EmployeeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteAsync(Employee entity)
        {
            _context.Employees.Remove(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            return await _context.Employees.ToListAsync();
        }

        public async Task<Employee> GetAsync(Guid id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Employee> GetByEmployeeIdAsync(string? id)
        {
            return await _context.Employees.FirstOrDefaultAsync(e => e.EmployeeNo == id);
        }

        public async Task InsertAsync(Employee entity)
        {
            _context.Employees.Add(entity);

            await _context.SaveChangesAsync();
        }

        public async Task<bool> IsInUseAsync(Guid id)
        {
            var employee = await _context.Employees.FirstOrDefaultAsync(e => e.Id == id);

            return employee.Status == Status.Enabled;
        }

        public async Task UpdateAsync(Employee entity)
        {
            _context.Employees.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
