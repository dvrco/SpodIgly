using System.Data.Entity;
using SpodIgly.Models;

namespace SpodIgly.DAL
{
    public class StoreContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }

        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        public StoreContext() : base("StoreContext")
        {

        }
    }
}