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
    public class WorkPositionTypeConfigurations : IEntityTypeConfiguration<WorkPosition>
    {
        public void Configure(EntityTypeBuilder<WorkPosition> builder)
        {
            builder
            .ToTable("work_position")
            .Property(wp => wp.Id)
            .ValueGeneratedOnAdd();

            builder
                .Property(wp => wp.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(wp => wp.Name)
                .HasColumnName("name")
                .IsRequired();

            builder
                .Property(wp => wp.StartTime)
                .HasColumnName("start_time")
                .HasColumnType("time")
                .IsRequired();

            builder
              .Property(wp => wp.EndTime)
              .HasColumnName("end_time")
              .HasColumnType("time")
              .IsRequired();

            builder
                .Property(wp => wp.WorkCode)
                .HasColumnName("work_code")
                .IsRequired();

            builder
                .HasMany(wp => wp.Employees)
                .WithOne(wp => wp.WorkPosition)
                .HasForeignKey(wp => wp.WorkPositionId)
                .OnDelete(DeleteBehavior.NoAction);

            //builder
            //    .HasData(new WorkPosition
            //{
            //    Id = Guid.NewGuid(),
            //    Name = "NetCoreDeveloper",
            //    WorkCode = "NCD",
            //    StartTime = 
            //});
        }
    }
}
