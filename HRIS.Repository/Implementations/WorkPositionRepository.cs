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
    public class WorkPositionRepository : BaseRepository, IWorkPositionRepository
    {
        public WorkPositionRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task DeleteAsync(WorkPosition entity)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<WorkPosition>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<WorkPosition> GetAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<WorkPosition> GetAsync(string workCode)
        {
            return await Context.WorkPositions.Where(wp => wp.WorkCode == workCode).SingleOrDefaultAsync();
        }

        public Task InsertAsync(WorkPosition entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(WorkPosition entity)
        {
            throw new NotImplementedException();
        }
    }
}
