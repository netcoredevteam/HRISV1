using HRIS.Domain.Entities;
using HRIS.Domain.Enums;
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
            new ScheduleEntityTypeConfiguration().Configure(modelBuilder.Entity<Schedule>());
            new DailyRecordEntityTypeConfiguration().Configure(modelBuilder.Entity<DailyRecord>());
            new MandatoryEntityTypeConfiguration().Configure(modelBuilder.Entity<Mandatory>());
            new LeaveRecordTypeConfiguration().Configure(modelBuilder.Entity<LeaveRecord>());
            new CalendarTaskEntityTypeConfiguration().Configure(modelBuilder.Entity<CalendarTask>());
            new AnnouncementEntityTypeConfiguration().Configure(modelBuilder.Entity<Announcement>());
            new WhitelistEntityTypeConfiguration().Configure(modelBuilder.Entity<Whitelist>());


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee>? Employees { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<WorkPosition>? WorkPositions { get; set; }
        public DbSet<Schedule>? Schedules { get; set; }
        public DbSet<DailyRecord> DailyRecords { get; set; }
        public DbSet<Mandatory> Mandatories { get; set; }
        public DbSet<LeaveRecord> LeaveRecords { get; set; }
        public DbSet<CalendarTask> CalendarTasks { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Whitelist> Whitelists { get; set; }


        public async Task<int> SaveChangesAsync() => await base.SaveChangesAsync();
    }
}
