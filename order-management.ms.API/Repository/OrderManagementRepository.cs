using Microsoft.EntityFrameworkCore;
using order_management.ms.API.Data;

namespace order_management.ms.API.Repository
{
    public class OrderManagementRepository
    {
        private readonly OrderManagementDBContext _dbContext;

        public OrderManagementRepository(OrderManagementDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveOrderItemAsync(OrderItem orderItem)
        {
            if (orderItem == null) throw new Exception(nameof(orderItem));

            _dbContext.Set<OrderItem>().Add(orderItem);
            await _dbContext.SaveChangesAsync();
        }

    }
}
