using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class AddressFilter : IFilter<Address>
{
    public string? Id { get; set; }
    public IQueryable<Address> Apply(IQueryable<Address> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);
        
        return queryable;
    }
}