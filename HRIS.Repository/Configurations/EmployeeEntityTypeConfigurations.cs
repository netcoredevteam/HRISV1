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
    public class EmployeeEntityTypeConfigurations : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder
                .ToTable("employees")
                .HasKey(e => e.Id);

            builder
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(e => e.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(e => e.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(e => e.DateHired)
                .HasColumnName("date_hired")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(e => e.BirthDate)
                .HasColumnName("birth_date")
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(e => e.Address)
                .HasMaxLength(50)
                .HasColumnName("address")
                .IsRequired();

            builder
                .Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone")
                .IsRequired();

            builder
                .Property(e => e.ContactName)
                .HasMaxLength(50)
                .HasColumnName("contact_name")
                .IsRequired();

            builder
                .Property(e => e.ContactNo)
                .HasMaxLength(50)
                .HasColumnName("contact_no")
                .IsRequired();

            builder
                .Property(e => e.EmployeeNo)
                .HasColumnName("employee_no")
                .IsRequired();

            builder
                .Property(e => e.WorkPositionId)
                .HasColumnName("work_position_id")
                .IsRequired();

            builder
                .Property(e => e.ScheduleId)
                .HasColumnName("schedule_id")
                .IsRequired();

            builder
                .HasOne(e => e.WorkPosition)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.WorkPositionId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasMany(e => e.Users)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(e => e.Schedule)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.ScheduleId);

            builder
                .HasMany(e => e.DailyRecords)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId);

            builder
                .HasOne(m => m.Mandatory)
                .WithOne(m => m.Employee)
                .HasForeignKey<Employee>(m => m.MandatoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
