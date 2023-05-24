using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class GroceryListSeeding
{
    public static void Seed(this EntityTypeBuilder<GroceryList> builder)
    {
        builder.HasData(
            new GroceryList
            {
                Id = "fd7103b9-cee0-4a2e-b1dc-b689637e32a7",
                Note = "This is a test grocery list",
                UserId = "4ba894c6-cd7b-48c1-92c9-bcda8dadf9ec",
                StoreId = "2b1bb8b2-4fb7-46fb-b97b-a50bca6a7e3b"
            });
    }
}