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
                .Property(wp => wp.WorkCode)
                .HasColumnName("work_code")
                .IsRequired();

            builder
                .HasMany(wp => wp.Employees)
                .WithOne(wp => wp.WorkPosition)
                .HasForeignKey(wp => wp.WorkPositionId)
                .OnDelete(DeleteBehavior.NoAction);

            builder
                .HasData(
                new WorkPosition
                {
                    Id = Guid.NewGuid(),
                    Name = "NetCore Developer",
                    WorkCode = "NCD",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new WorkPosition
                {
                    Id = Guid.NewGuid(),
                    Name = "Frontend Developer",
                    WorkCode = "FED",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                new WorkPosition
                {
                    Id = Guid.NewGuid(),
                    Name = "Chat Support",
                    WorkCode = "CS",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System",
                },
                 new WorkPosition
                 {
                     Id = Guid.NewGuid(),
                     Name = "Marketing",
                     WorkCode = "MKT",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                 },
                 new WorkPosition
                 {
                     Id = Guid.NewGuid(),
                     Name = "Affiliate",
                     WorkCode = "AFF",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                 },
                 new WorkPosition
                 {
                     Id = Guid.NewGuid(),
                     Name = "Data Analyst",
                     WorkCode = "DA",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                 },
                 new WorkPosition
                 {
                     Id = Guid.NewGuid(),
                     Name = "Human Resource",
                     WorkCode = "HR",
                     CreatedAt = DateTime.Now,
                     UpdatedAt = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System",
                 });
        }
    }
}
