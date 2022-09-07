using HRIS.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRIS.Repository.Configurations
{
    public class MenuEntityTypeConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder
                .ToTable("menus")
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(s => s.Page)
                .HasColumnName("page")
                .HasMaxLength(50)
                .IsRequired();
            builder
                .Property(s => s.Title)
                .HasColumnName("title")
                .HasMaxLength(50)
                .IsRequired();
            builder
               .Property(s => s.IsShown)
               .HasColumnName("is_shown");
            builder
                .Property(s => s.Icon)
                .HasColumnName("icon")
                .HasMaxLength(50)
                .IsRequired();
            builder
               .Property(s => s.Sort)
               .HasColumnName("sort");
        }
    }
}
