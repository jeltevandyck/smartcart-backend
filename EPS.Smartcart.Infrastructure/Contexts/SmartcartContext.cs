using System.Reflection;
using EPS.Smartcart.Domain;
using EPS.Smartcart.Infrastructure.Seeding;
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
    public DbSet<GroceryList> GroceryLists { get; set; }
    public DbSet<GroceryItem> GroceryItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        
        //TODO Seeding
        UserSeeding.Seed(modelBuilder.Entity<User>());
        AddressSeeding.Seed(modelBuilder.Entity<Address>());
        StoreSeeding.Seed(modelBuilder.Entity<Store>());
        ProductSeeding.Seed(modelBuilder.Entity<Product>());
        GroceryListSeeding.Seed(modelBuilder.Entity<GroceryList>());
        CartSeeding.Seed(modelBuilder.Entity<Cart>());
        OrderSeeding.Seed(modelBuilder.Entity<Order>());
    }
}