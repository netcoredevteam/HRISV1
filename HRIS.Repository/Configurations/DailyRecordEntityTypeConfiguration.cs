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
    public class DailyRecordEntityTypeConfiguration : IEntityTypeConfiguration<DailyRecord>
    {
        public void Configure(EntityTypeBuilder<DailyRecord> builder)
        {
            builder
                .ToTable("daily_records")
                .HasKey(dr => dr.Id);

            builder
                .Property(dr => dr.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(dr => dr.EmployeeId)
                .HasColumnName("employee_id")
                .IsRequired();

            builder
                .Property(dr => dr.TimeIn)
                .HasColumnName("time_in")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.TimeOut)
                .HasColumnName("time_out")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.LunchIn)
                .HasColumnName("lunch_in")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.LunchOut)
                .HasColumnName("lunch_out")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.OTIn)
                .HasColumnName("ot_in")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.OTOut)
                .HasColumnName("ot_out")
                .HasColumnType("datetime");

            builder
                .Property(dr => dr.IsDelete)
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .HasOne(dr => dr.Employee)
                .WithMany(dr => dr.DailyRecords)
                .HasForeignKey(dr => dr.EmployeeId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
