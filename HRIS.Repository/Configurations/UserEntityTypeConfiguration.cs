using HRIS.Domain.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRIS.Repository.Configurations
{
    public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .ToTable("users")
                .HasKey(u => u.Id);

            builder
                .Property(u => u.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(u => u.Username)
                .HasColumnName("username")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.EmployeeId)
                .HasColumnName("employee_id")
                .HasMaxLength(50);

            builder
                .Property(u => u.Password)
                .HasColumnName("password")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Role)
                .HasColumnName("role")
                .HasDefaultValue("User")
                .HasMaxLength(50)
                .IsRequired();

            builder
                .Property(u => u.Nickname)
                .HasColumnName("nickname")
                .HasMaxLength(50);

            builder
                .Property(u => u.Status)
                .HasColumnName("status")
                .IsRequired();

            builder
                .Property(u => u.LastLoginTime)
                .HasColumnName("last_login_time")
                .HasColumnType("datetime2")
                .IsRequired();

            builder
                .Property(u => u.ProfileImage)
                .HasColumnName("profile_image")
                .HasDefaultValue(null)
                .IsRequired();

            builder
                .HasOne(u => u.Employee)
                .WithMany(u => u.Users)
                .HasForeignKey(u => u.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasMany(u => u.LeaveRecords)
                .WithOne(u => u.User)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
