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
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Password)
                .HasColumnName("password")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Role)
                .HasColumnName("role")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(p => p.Status)
                .HasColumnName("status")
                .IsRequired();

            builder
                .Property(p => p.LastLoginTime)
                .HasColumnName("last_login_time")
                .HasColumnType("datetime2")
                .IsRequired();

            builder
                .HasOne(p => p.Employee)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            //public string? Username { get; set; }
            //public string? Password { get; set; }
            //public Role Role { get; set; }
            //public string? Nickname { get; set; }
            //public Status Status { get; set; }
            //public int IsDeleted { get; set; }
            //public DateTime LastLoginTime { get; set; }
    }
}
}
