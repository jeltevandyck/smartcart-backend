using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class AddressSeeding
{
    public static void Seed(this EntityTypeBuilder<Address> builder)
    {
        builder.HasData(
            new Address
            {
                Id = "14360a63-02c7-4d56-a234-611b3afa88c1",
                Street = "Small Street",
                Number = "1297",
                Extra = "",
                City = "New York",
                PostalCode = "10007",
                State = "New York",
                Country = "United States",
            },
            new Address
            {
                Id = "559e7d12-133e-463f-a6b3-9689423951d4",
                Street = "Massachusetts Avenue",
                Number = "1666",
                Extra = "",
                City = "Washington",
                State = "Washington D.C.",
                PostalCode = "20024",
                Country = "United States",
            },
            new Address
            {
                Id = "b35ef492-3852-4dbe-9510-0563bab99ca1",
                Street = "Anmoore Road",
                Number = "3903",
                Extra = "",
                City = "Bayside",
                State = "New York",
                PostalCode = "11361",
                Country = "United States",
            },
            new Address
            {
                Id = "661f8232-4c4e-4dfd-bc08-b1f38f3cef98",
                Street = "Edwards Street",
                Number = "975",
                Extra = "",
                City = "Rocky Mount",
                PostalCode = "27801",
                State = "North Carolina",
                Country = "United States",
            }
        );
    }
}