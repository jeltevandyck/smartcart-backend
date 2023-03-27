using EPS.Smartcart.Application.Filters;
using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Repositories;

public abstract class AbstractRepository<T> : IRepository<T> where T : Entity
{
    public DbSet<T> Data { get; }
    
    public AbstractRepository(DbSet<T> data)
    {
        Data = data;
    }
    
    public async Task<IEnumerable<T>> GetAll(IFilter<T> filter, PaginationFilter<T> paginationFilter)
    {
        var queryable = Data.AsQueryable();

        queryable = filter.Apply(queryable);
        
        queryable = paginationFilter.Apply(queryable);

        queryable = Include(queryable);
        
        return await queryable.ToListAsync();
    }

    public async Task<T> GetById(string id)
    {
        return await Data.FirstOrDefaultAsync(x => x.Id.Equals(id));
    }

    public T Create(T entity)
    {
        var address = Data.Add(entity);
        return address.Entity;
    }

    public T Update(T entity)
    {
        var address = Data.Update(entity);
        return address.Entity;
    }

    public T Delete(T entity)
    {
        return Data.Remove(entity).Entity;
    }

    public abstract IQueryable<T> Include(IQueryable<T> queryable);
}