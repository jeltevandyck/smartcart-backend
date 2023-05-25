using EPS.Smartcart.Application.Interfaces;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Contexts;
using EPS.Smartcart.Infrastructure.Repositories;
using EPS.Smartcart.Infrastructure.UoW;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EPS.Smartcart.Infrastructure.Extensions;

public static class Registrator
{
    public static IServiceCollection RegisterInfrastructure(this IServiceCollection service)
    {
        service.RegisterDbContext();
        service.RegisterRepositories();
        return service;
    }

    public static IServiceCollection RegisterDbContext(this IServiceCollection service)
    {
        service.AddDbContext<SmartcartContext>(options =>
        {
            options.UseSqlServer("name=ConnectionStrings:smartcart_db");
            options.EnableSensitiveDataLogging();
        });

        return service;
    }

    public static IServiceCollection RegisterRepositories(this IServiceCollection service)
    {
        service.AddScoped<IRepository<User>, UserRepository>();
        service.AddScoped<IRepository<Address>, AddressRepository>();
        service.AddScoped<IRepository<Product>, ProductRepository>();
        service.AddScoped<IRepository<Store>, StoreRepository>();
        service.AddScoped<IRepository<Cart>, CartRepository>();
        service.AddScoped<IRepository<Order>, OrderRepository>();
        service.AddScoped<IRepository<OrderItem>, OrderItemRepository>();
        service.AddScoped<IRepository<GroceryList>, GroceryListRepository>();
        service.AddScoped<IRepository<GroceryItem>, GroceryItemRepository>();
        service.AddScoped<IUnitOfWork, UnitOfWork>();
        return service;
    }
}