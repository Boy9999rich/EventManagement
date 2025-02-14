using EventManagement.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Dal.EntityConfiguration;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("User");

        builder.HasKey(b => b.UserId);

        builder.Property(b => b.Name)
            .IsRequired(true)
            .HasMaxLength(20);

        builder.Property(b => b.Email)
            .IsRequired(true)
            .HasMaxLength(50);

        builder.Property(b => b.Role)
            .IsRequired(true);

        builder.HasMany(b => b.FeedBacks)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.UserId);
    }
}
