using HRIS.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Configurations
{
    internal class ScheduleEntityTypeConfiguration : IEntityTypeConfiguration<Schedule>
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
                .Property(s => s.CreateTime)
                .HasColumnName("create_time")
                .IsRequired();
            builder
                .Property(s => s.UpdateTime)
                .HasColumnName("update_time")
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
        }
    }
}
