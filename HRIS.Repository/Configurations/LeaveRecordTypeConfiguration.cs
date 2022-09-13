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
    public class LeaveRecordTypeConfiguration : IEntityTypeConfiguration<LeaveRecord>
    {
        public void Configure(EntityTypeBuilder<LeaveRecord> builder)
        {
            builder
                .ToTable("leave_records")
                .HasKey(lr => lr.Id);

            builder
                .Property(lr => lr.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(lr => lr.Status)
                .HasColumnName("status");

            builder
                .Property(lr => lr.FiledDate)
                .HasColumnName("filed_date")
                .HasColumnType("datetime");

            builder
                .Property(lr => lr.LeaveStartDate)
                .HasColumnName("leave_start_date")
                .HasColumnType("datetime");

            builder
                .Property(lr => lr.LeaveEndDate)
                .HasColumnName("leave_end_date")
                .HasColumnType("datetime");

            builder
                .Property(lr => lr.ReasonOfLeave)
                .HasColumnName("reason_of_leave");

            builder
                .Property(lr => lr.UserId)
                .HasColumnName("user_id");

            builder
                .Property(lr => lr.Remarks)
                .HasColumnName("remarks");

            builder
                .Property(lr => lr.Leavetype)
                .HasColumnName("leave_type")
                .HasComment("1 with pay, 0 w/o pay");

            builder
                .HasOne(lr => lr.User)
                .WithMany(lr => lr.LeaveRecords)
                .HasForeignKey(lr => lr.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
