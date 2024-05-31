using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Infrastructure.DB.Configurations
{
    public class EntityConfiguration<T> : IEntityTypeConfiguration<T> where T : ComponenentEntity<T>
    {
        public void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);

            builder.Property(a => a.ID)
                .HasConversion(
                CaseID => CaseID.ID,
                Value => new TypedID<T>(Value));
        }
    }
}
