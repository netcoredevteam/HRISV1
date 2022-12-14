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
    public class MandatoryEntityTypeConfiguration : IEntityTypeConfiguration<Mandatory>
    {
        public void Configure(EntityTypeBuilder<Mandatory> builder)
        {
            builder
                .ToTable("mandatory")
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(m => m.EmployeeId)
                .HasColumnName("employee_id")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.SSS)
                .HasColumnName("sss")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.PagIbig)
                .HasColumnName("pag_ibig")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.PhilHealth)
                .HasColumnName("phil_health")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.TIN)
                .HasColumnName("tin")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(m => m.HMO)
                .HasColumnName("hmo")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .HasOne(m => m.Employee)
                .WithOne(m => m.Mandatory)
                .HasForeignKey<Employee>(m => m.MandatoryId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
