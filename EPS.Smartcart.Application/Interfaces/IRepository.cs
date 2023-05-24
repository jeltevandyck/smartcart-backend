using System.Linq.Expressions;
using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Domain;

namespace EPS.Smartcart.Application.Interfaces;

public interface IRepository<T> where T : Entity
{
    Task<IEnumerable<T>> GetAll(IFilter<T> filter, PaginationFilter<T> paginationFilter);
    Task<T> GetById(string id);
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
    Task<List<T>> Query(Expression<Func<T, bool>> predicate);
}