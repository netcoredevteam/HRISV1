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
    public class DailyRecordRepository : BaseRepository, IDailyRecordRepository
    {
        public DailyRecordRepository(ApplicationDbContext context) : base(context)
        { }

        public async Task DeleteAsync(DailyRecord entity)
        {
            Context.DailyRecords.Remove(entity);
        }

        public async Task<IEnumerable<DailyRecord>> GetAllAsync()
        {
            return await Context.DailyRecords.ToListAsync();
        }

        public async Task<IEnumerable<DailyRecord>> GetAllByEmployeeNoAsync(string? employeeNo)
        {
            var employee = await Context.Employees.FirstOrDefaultAsync(e => e.EmployeeNo == employeeNo);
            var dailyRecords = await Context.DailyRecords.Where(dr => dr.EmployeeId == employee.Id).ToListAsync();

            return dailyRecords;
        }

        public async Task<DailyRecord> GetAsync(Guid id)
        {
            return await Context.DailyRecords.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task InsertAsync(DailyRecord entity)
        {
            await Context.DailyRecords.AddAsync(entity);
        }

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }

        public async Task UpdateAsync(DailyRecord entity)
        {
            Context.DailyRecords.Update(entity);
        }
    }
}
