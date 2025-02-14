using EventManagement.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Dal.EntityConfiguration;

public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable("Event");

        builder.HasKey(b => b.EventId);

        builder.Property(b => b.Name)
            .IsRequired(true)
            .HasMaxLength(50);
        builder.Property(b => b.CreatedTime)
            .IsRequired(true);

        builder.Property(b => b.Location)
            .IsRequired(true);

        builder.HasMany(b => b.Users)
            .WithOne(b => b.Event)
            .HasForeignKey(b => b.EventId);

        builder.HasOne(b => b.Organizer)
            .WithMany(b => b.Events)
            .HasForeignKey(b => b.OrganizerId)
            .OnDelete(DeleteBehavior.Restrict);
            
    }
}
