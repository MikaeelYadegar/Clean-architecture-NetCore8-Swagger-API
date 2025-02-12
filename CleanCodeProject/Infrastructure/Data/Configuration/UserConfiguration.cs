using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

internal class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
       builder.HasKey(u => u.Id);
        builder.HasMany(u => u.UserRoles)
                .WithOne()
                .HasForeignKey(ur=>ur.UserId)
                .OnDelete(DeleteBehavior.Cascade);
       builder.Property(u=>u.FirstName).HasMaxLength(100).IsRequired();
        builder.Property(u => u.LastName).HasMaxLength(150).IsRequired();
        builder.Property(u=>u.Password).HasMaxLength(50).IsRequired();
        builder.HasIndex(u => new { u.UserName }).IsUnique();

    }
}
