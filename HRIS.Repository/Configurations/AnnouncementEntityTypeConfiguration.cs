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
    public class AnnouncementEntityTypeConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {
            builder
                .ToTable("announcements")
                .HasKey(a => a.Id);

            builder
                .Property(a => a.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(a => a.Title)
                .HasColumnName("title");

            builder
               .Property(a => a.Message)
               .HasColumnName("message");

            builder
                .Property(a => a.CreatedBy)
                .HasColumnName("created_by")
                .HasColumnType("varchar");

            builder
                .Property(a => a.CreatedAt)
                .HasColumnName("created_at")
                .HasColumnType("datetime");

            builder
                .Property(a => a.UpdatedBy)
                .HasColumnName("updated_by")
                .HasColumnType("varchar");

            builder
                .Property(a => a.UpdatedAt)
                .HasColumnName("update_at")
                .HasColumnType("datetime"); 
        }
    }
}
