using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal sealed class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.HasKey(order => order.Id);
        builder.Property(o => o.Id).HasConversion(id => id.Value,
                             val => new(val));

        builder.HasOne(o => o.Provider)
               .WithMany()
               .HasForeignKey(o => o.ProviderId)
               .IsRequired();

        builder.HasMany(o => o.Items)
               .WithOne()
               .HasForeignKey(i => i.OrderId)
               .IsRequired();

        builder.HasIndex(o => new { o.Number, o.ProviderId })
               .IsUnique();


    }
}
