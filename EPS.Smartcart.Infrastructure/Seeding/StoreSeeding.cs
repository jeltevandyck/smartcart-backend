using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class StoreSeeding
{
    public static void Seed(this EntityTypeBuilder<Store> builder)
    {
        builder.HasData(
            new Store
            {
                Id = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b",
                Name = "Froiz",
                AddressId = "14360a63-02c7-4d56-a234-611b3afa88c1"
            },
            new Store
            {
                Id = "e6d39016-4c8e-479e-84b6-5c6c01acac4e",
                Name = "Continente",
                AddressId = "559e7d12-133e-463f-a6b3-9689423951d4"
            },
            new Store
            {
                Id = "39791b70-3223-42cb-b345-be7be62ffa81",
                Name = "Aldi",
                AddressId = "b35ef492-3852-4dbe-9510-0563bab99ca1"
            },
            new Store
            {
                Id = "6af975e1-ef09-4dad-8c9b-1e329afe91fc",
                Name = "Lidl",
                AddressId = "661f8232-4c4e-4dfd-bc08-b1f38f3cef98"
            }
        );
    }
}