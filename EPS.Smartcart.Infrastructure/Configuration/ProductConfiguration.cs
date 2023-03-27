using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Configuration;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("tblProducts");
        builder.HasKey(x => x.Id);
        
        builder.HasOne(x => x.Store);
    }
}