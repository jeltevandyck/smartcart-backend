using System.Reflection;
using EPS.Smartcart.Domain;
using Microsoft.EntityFrameworkCore;

namespace EPS.Smartcart.Infrastructure.Contexts;

public class SmartcartContext : DbContext
{
    public SmartcartContext()
    {
        
    }

    public SmartcartContext(DbContextOptions<SmartcartContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Address> Addresses { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Store> Stores { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}