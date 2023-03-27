using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("tblOrders");
        builder.HasKey(x => x.Id);
        builder.HasMany(x => x.OrderItems)
            .WithOne()
            .HasForeignKey(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}