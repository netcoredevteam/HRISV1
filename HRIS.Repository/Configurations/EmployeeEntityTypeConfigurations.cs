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
                .HasColumnName("address");

            builder
                .Property(e => e.Phone)
                .HasColumnName("phone");

            builder
                .Property(e => e.ContactName)
                .HasColumnName("contact_name");

            builder
                .Property(e => e.ContactNo)
                .HasColumnName("contact_no");

            builder
                 .Property(e => e.ProfileImage)
                 .HasColumnName("profile_image")
                 .HasColumnType("text")
                 .IsRequired();

            builder
                .HasOne(e => e.WorkPosition)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.WorkPositionId);

            builder
                .HasMany(e => e.Users)
                .WithOne(e => e.Employee)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder
                .HasOne(e => e.Schedule)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.ScheduleId);
        }
    }
}
