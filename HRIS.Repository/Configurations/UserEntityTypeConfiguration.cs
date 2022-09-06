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
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("users")
                .HasKey(p => p.Id);

            builder
                .Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(p => p.Username)
                .HasColumnName("username")
                .HasMaxLength(64)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .HasMaxLength(64)
                .HasColumnName("password")
                .IsRequired();

            builder
                .Property(p => p.Nickname)
                .HasColumnName("nickname")
                .HasMaxLength(64);

            builder
                .Property(p => p.UserRole)
                .HasColumnName("user_role");

            builder
                .Property(p => p.LastLoginTime)
                .HasColumnName("last_login_time");

            builder
                .Property(p => p.IsDeleted)
                .HasColumnName("is_deleted")
                .IsRequired();

            builder
                .Property(p => p.Status)
                .HasColumnName("status")
                .IsRequired();

            builder
                .HasOne(p => p.Employee)
                .WithOne()
                .HasForeignKey("employee_id")
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
