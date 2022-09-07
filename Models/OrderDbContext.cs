using Microsoft.EntityFrameworkCore;

namespace RagazAPI.Models
{
    public class OrderDbContext:DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options):base(options)
        {}

        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
