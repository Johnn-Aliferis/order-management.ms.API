using Microsoft.EntityFrameworkCore;

namespace order_management.ms.API.Data
{
    public class OrderManagementDBContext : DbContext
    {
        public OrderManagementDBContext(DbContextOptions options) : base(options) { }

        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
