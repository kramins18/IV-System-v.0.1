using InternetVeikals.Models.Cart;
using InternetVeikals.Models.Order;
using InternetVeikals.Models.Product;
using InternetVeikals.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace InternetVeikals.Data
{
    /// <summary>
    /// Data base context class
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> opt) : base(opt)
        {
        }

        // ADDING DATA SETS TO ENTITY FRAMEWORK DBContext
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<OrderItem> OrderItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<CartProduct> CartProduct { get; set; }
    }
}