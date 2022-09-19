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
    public class WhitelistEntityTypeConfiguration : IEntityTypeConfiguration<Whitelist>
    {
        public void Configure(EntityTypeBuilder<Whitelist> builder)
        {
            builder
                .ToTable("whitelists")
                .HasKey(s => s.Id);

            builder
                .Property(s => s.Ip)
                .HasColumnName("ip")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(s => s.Remark)
                .HasColumnName("remark")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(s => s.IsDelete)
                .HasDefaultValue(false)
                .IsRequired();

            builder
                .Property(s => s.CreatedAt)
                .HasColumnName("create_time")
                .IsRequired();

            builder
                .Property(s => s.UpdatedAt)
                .HasColumnName("update_time")
                .IsRequired();
        } 
    }
}
