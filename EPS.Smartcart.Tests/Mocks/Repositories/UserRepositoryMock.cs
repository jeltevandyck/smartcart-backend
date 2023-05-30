using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Tests.Mocks.Repositories;

public class UserRepositoryMock : AbstractMockRepository<UserFilter, User, IRepository<User>>
{
    public override List<User> CreateData()
    {
        var users = new List<User>();
        return users;
    }
}