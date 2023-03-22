using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class UserFilter : IFilter<User>
{
    public string? Id { get; set; }
    public IQueryable<User> Apply(IQueryable<User> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);

        return queryable;
    }
}