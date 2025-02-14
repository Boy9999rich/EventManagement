using EventManagement.Dal.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManagement.Dal.EntityConfiguration;

public class FeedBackConfiguration : IEntityTypeConfiguration<FeedBack>
{
    public void Configure(EntityTypeBuilder<FeedBack> builder)
    {
        builder.ToTable("FeedBack");

        builder.HasKey(b => b.FeedBackId);

        builder.Property(b => b.Rating)
            .IsRequired(true);

        builder.Property(b => b.Comment)
            .IsRequired(true);
    }
}
