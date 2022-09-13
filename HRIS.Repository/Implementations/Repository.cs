using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Implementations
{
    public abstract class Repository
    {
        protected ApplicationDbContext Context { get; }
        public Repository(ApplicationDbContext context) => Context = context;
    }
}
