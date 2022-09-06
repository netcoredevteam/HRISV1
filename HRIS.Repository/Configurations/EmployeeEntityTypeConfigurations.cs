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
                .Property(p => p.FirstName)
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.LastName)
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(p => p.DateHired)
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(p => p.BirthDate)
                .HasColumnType("date")
                .IsRequired();
        }
    }
}
