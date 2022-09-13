using HRIS.Domain.Entities;
using HRIS.Domain.Enums;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HRIS.Repository.Configurations
{
    public class ScheduleEntityTypeConfiguration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder
                .ToTable("schedules")
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(s => s.StartTime)
                .HasColumnName("start_time")
                .IsRequired();
            builder
                .Property(s => s.EndTime)
                .HasColumnName("end_time")
                .IsRequired();

            builder
               .Property(s => s.Status)
               .HasColumnName("status")
               .IsRequired();

            builder
                .HasMany(s => s.Employees)
                .WithOne(e => e.Schedule)
                .HasForeignKey(e => e.ScheduleId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasData(
                new Schedule
                {
                    Id = Guid.NewGuid(),
                    Name = "Morning Shift",
                    StartTime = new DateTime(1, 1, 1, 11, 0, 0),
                    EndTime = new DateTime(1, 1, 1, 20, 0, 0),
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Schedule
                {
                    Id = Guid.NewGuid(),
                    Name = "Night Shift",
                    StartTime = new DateTime(1, 1, 1, 20, 0, 0),
                    EndTime = new DateTime(1, 1, 1, 05, 0, 0),
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Schedule
                {
                    Id = Guid.NewGuid(),
                    Name = "Marketing Shift",
                    StartTime = new DateTime(1, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1, 1, 1, 19, 0, 0),
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Schedule
                {
                    Id = Guid.NewGuid(),
                    Name = "IT Shift",
                    StartTime = new DateTime(1, 1, 1, 10, 0, 0),
                    EndTime = new DateTime(1, 1, 1, 19, 0, 0),
                    Status = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Schedule
                 {
                     Id = Guid.NewGuid(),
                     Name = "HR Shift",
                     StartTime = new DateTime(1, 1, 1, 10, 0, 0),
                     EndTime = new DateTime(1, 1, 1, 19, 0, 0),
                     Status = 1,
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 });
        }
    }
}
