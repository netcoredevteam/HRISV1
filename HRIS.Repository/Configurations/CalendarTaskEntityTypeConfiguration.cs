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
    public class CalendarTaskEntityTypeConfiguration : IEntityTypeConfiguration<CalendarTask>
    {
        public void Configure(EntityTypeBuilder<CalendarTask> builder)
        {
            builder
                .ToTable("calendar_tasks")
                .HasKey(dr => dr.Id);

            builder
                .Property(dr => dr.Id)
                .ValueGeneratedOnAdd();
            
            builder
                .Property(p => p.Title)
                .HasColumnName("title")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Description)
                .HasColumnName("description")
                .HasColumnType("text")
                .IsRequired();

            builder
                .Property(p => p.DateTask)
                .HasColumnName("date_task")
                .HasColumnType("datetime")
                .IsRequired();
        }
    }
}
