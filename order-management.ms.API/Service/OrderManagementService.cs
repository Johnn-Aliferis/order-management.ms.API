using order_management.ms.API.Data;
using order_management.ms.API.Mappers;
using order_management.ms.API.Repository;

namespace order_management.ms.API.Service
{
    public class OrderManagementService
    {
        private readonly OrderManagementRepository _repository;

        public OrderManagementService(OrderManagementRepository repository)
        {
            _repository = repository;
        }

        public Boolean ValidateOrder(OrderItemDTO orderItemDTO)
        {
            // perform validation through db if needed.
            return true;
        }

        public async Task<Boolean> SaveOrder(OrderItemDTO orderItemDTO)
        {
            var entity = OrderItemMapper.ToEntity(orderItemDTO);
            await _repository.SaveOrderItemAsync(entity);
            return true;
        }
    }
}
