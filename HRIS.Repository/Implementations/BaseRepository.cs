using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public class BaseRepository
    {
        protected ApplicationDbContext Context { get; }
        public BaseRepository(ApplicationDbContext context) => Context = context;

        public async Task SaveChangesAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
