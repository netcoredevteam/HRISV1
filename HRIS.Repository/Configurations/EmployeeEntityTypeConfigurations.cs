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
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.EmployeeNo)
                .HasColumnName("employee_no")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.FirstName)
                .HasColumnName("first_name")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasColumnName("last_name")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.Birthdate)
                .HasColumnName("birth_date")
                .IsRequired();

            builder
                .Property(p => p.DateHired)
                .HasColumnName("date_hired")
                .IsRequired();

            builder
                .Property(p => p.Address)
                .HasColumnName("address")
                .HasMaxLength(128)
                .IsRequired();

            builder
                .Property(p => p.Phone)
                .HasColumnName("phone")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.EmergencyContactName)
                .HasColumnName("emergency_contact_name")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.EmergencyContactNo)
                .HasColumnName("emergency_contact_no")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.WorkPosition)
                .HasColumnName("work_position")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.ScheduleId)
                .HasColumnName("schedule_id")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.ProfileImage)
                .HasColumnName("profile_image")
                .HasMaxLength(255)
                .IsRequired();
        }
    }
}
