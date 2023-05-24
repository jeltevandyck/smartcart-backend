using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Filters;

public class ProductFilter : IFilter<Product>
{
    public string? Id { get; set; }
    public string? StoreId { get; set; }
    
    public IQueryable<Product> Apply(IQueryable<Product> queryable)
    {
        if (Id != null) queryable = queryable.Where(x => x.Id == Id);
        
        if (StoreId != null) queryable = queryable.Where(x => x.StoreId == StoreId);

        return queryable;
    }
}