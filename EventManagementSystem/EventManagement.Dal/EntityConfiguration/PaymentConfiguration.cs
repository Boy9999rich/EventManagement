using EventManagement.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Dal.EntityConfiguration;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("Payment");

        builder.HasKey(b => b.PaymentId);

        builder.Property(b => b.Amount)
            .IsRequired(true);

        builder.Property(b => b.Status)
            .IsRequired(true);
    }
}
