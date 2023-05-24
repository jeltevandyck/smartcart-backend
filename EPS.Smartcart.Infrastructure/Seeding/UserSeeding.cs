using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EPS.Smartcart.Infrastructure.Seeding;

public static class UserSeeding
{
    public static void Seed(this EntityTypeBuilder<User> builder)
    {
        builder.HasData(
            new User
            {
                Id = "4ba894c6-cd7b-48c1-92c9-bcda8dadf9ec",
                FirstName = "Jelte",
                LastName = "Van Dyck",
                Email = "jeltevandyck@hotmail.com",
                BirthDate = new DateTime(2001, 5,5)
            },
            new User
            {
                Id = "3f4ade99-c07b-4201-bc57-1dfa8538d90b",
                FirstName = "Albert",
                LastName = "Einstein",
                Email = "albert.einstein@gmail.com",
                BirthDate = new DateTime(1879, 3, 14)
            },
            new User
            {
                Id = "f7601c34-ae4e-4497-b244-49afa736afe9",
                FirstName = "Isaac",
                LastName = "Newton",
                Email = "isaac.newton@gmail.com",
                BirthDate = new DateTime(1643, 1, 4)
            },
            new User
            {
                Id = "558ff9a9-da5a-435f-bde8-8e1f8a1f75dc",
                FirstName = "Marie",
                LastName = "Curie",
                Email = "marie.curie@skynet.be",
                BirthDate = new DateTime(1867, 11, 7)
            }
            );
    }
}