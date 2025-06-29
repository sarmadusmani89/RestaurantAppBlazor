using Microsoft.EntityFrameworkCore;

namespace ECommerceApi.Data
{
    public class ApplicationDbContext : DbContext

    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Order> Orders { get; set; }
        public DbSet<Models.OrderItem> OrderItems { get; set; }

    }
}
