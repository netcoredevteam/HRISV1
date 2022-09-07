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
                .Property(p => p.EmployeeId)
                .HasColumnName("employee_id")
                .HasMaxLength(50);

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
                .Property(p => p.Nickname)
                .HasColumnName("nickname")
                .HasMaxLength(50);

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
                .Property(p => p.ProfileImage)
                .HasColumnName("profile_image")
                .IsRequired();

            builder
                .HasOne(p => p.Employee)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);

    }
}
}
