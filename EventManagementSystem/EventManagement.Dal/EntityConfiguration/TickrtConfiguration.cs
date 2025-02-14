using EventManagement.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Dal.EntityConfiguration;

public class TickrtConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.ToTable("Ticket");

        builder.HasKey(b => b.TicketId);

        builder.Property(b => b.Price)
            .IsRequired(true);

        builder.Property(b => b.SeatNumber)
            .IsRequired(true);

        builder.HasOne(b => b.Payment)
            .WithOne(b => b.Ticket);
    }     
}
