using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Interfaces;

public interface IFilter<T> where T : Entity
{
    IQueryable<T> Apply(IQueryable<T> queryable);
}