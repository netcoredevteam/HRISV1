using HRIS.Domain.Entities;
using HRIS.Repository.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new EmployeeEntityTypeConfigurations().Configure(modelBuilder.Entity<Employee>());
            new UserEntityTypeConfiguration().Configure(modelBuilder.Entity<User>());

            new WorkPositionTypeConfigurations().Configure(modelBuilder.Entity<WorkPosition>());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<WorkPosition>? WorkPositions { get; set; }


        public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
