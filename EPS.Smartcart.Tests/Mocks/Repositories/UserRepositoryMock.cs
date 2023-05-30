using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class UserRepositoryMock : AbstractMockRepository<UserFilter, User, IRepository<User>>
{
    public override List<User> CreateData()
    {
        var users = new List<User>();

        users.Add(new User
        {
            Id = "c0a80101-0000-0000-0000-000000000001",
            FirstName = "Test",
            LastName = "Test",
            Email = "test@gmail.com",
            BirthDate = DateTime.Parse("1990-01-01"),
        });

        users.Add(new User
        {
            Id = "c0a80101-0000-0000-0000-000000000002",
            FirstName = "Test 2",
            LastName = "Test 2",
            Email = "test2@gmail.com",
            BirthDate = DateTime.Parse("1990-01-01"),
        });

        return users;
    }
}