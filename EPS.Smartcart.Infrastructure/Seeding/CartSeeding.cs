using EPS.Smartcart.Application.Utils;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Domain.Types;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class CartSeeding
{
    public static void Seed(this EntityTypeBuilder<Cart> builder)
    {
        builder.HasData(
            new Cart
            {
                Id = "306545b0-4457-4fd7-8966-f8fe25999b47",
                Status = CartStatus.STANDBY,
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Code = CodeUtil.Generate(8)
            },
            new Cart
            {
                Id = "e6d39016-4c8e-479e-84b6-5c6c01acac4e",
                Status = CartStatus.STANDBY,
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Code = CodeUtil.Generate(8)
            },
            new Cart
            {
                Id = "39791b70-3223-42cb-b345-be7be62ffa81",
                Status = CartStatus.STANDBY,
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Code = CodeUtil.Generate(8)
            },
            new Cart
            {
                Id = "6af975e1-ef09-4dad-8c9b-1e329afe91fc",
                Status = CartStatus.STANDBY,
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Code = CodeUtil.Generate(8)
            });
    }
}