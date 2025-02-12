using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configuration;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.HasKey(ur => ur.Id);
        builder.HasOne<User>()
            .WithMany()
            .HasForeignKey(u => u.Id)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        builder.HasOne<Role>()
                .WithMany()
                .HasForeignKey(u => u.Id)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

    }
}
