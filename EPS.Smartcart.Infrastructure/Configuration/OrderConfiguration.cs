using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EPS.Smartcart.Infrastructure.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("tblOrders");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Status).HasConversion(new EnumToStringConverter<OrderStatus>());
        
        builder.HasMany(x => x.OrderItems)
            .WithOne()
            .HasForeignKey(x => x.Id)
            .OnDelete(DeleteBehavior.Cascade);
    }
}