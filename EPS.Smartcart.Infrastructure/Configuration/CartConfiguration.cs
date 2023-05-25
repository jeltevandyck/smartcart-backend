using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EPS.Smartcart.Infrastructure.Configuration;

public class CartConfiguration : IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("tblCarts");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Status).HasConversion(new EnumToStringConverter<CartStatus>());
        
        builder.HasOne(x => x.Store);
    }
}