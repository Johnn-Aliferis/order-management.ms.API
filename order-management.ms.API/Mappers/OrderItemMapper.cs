using order_management.ms.API.Data;

namespace order_management.ms.API.Mappers
{
    public static class OrderItemMapper
    {
        //To DTO
        public static OrderItemDTO ToDTO(OrderItem entity)
        {
            if (entity == null) return null;

            return new OrderItemDTO
            {
                OrderId = entity.OrdeId,
                TotalAmount = entity.TotalAmount,
                OrderStatus = entity.OrderStatus,
                UserEmail = entity.UserEmail,
                UserPhone = entity.UserPhone,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt,
                OrderItems = entity.OrderItems
            };
        }

        //To entity
        public static OrderItem ToEntity(OrderItemDTO dto)
        {
            if (dto == null) return null;

            return new OrderItem
            {
                OrdeId = dto.OrderId,
                TotalAmount = dto.TotalAmount,
                OrderStatus = dto.OrderStatus,
                UserEmail = dto.UserEmail,
                UserPhone = dto.UserPhone,
                CreatedAt = dto.CreatedAt,
                UpdatedAt = dto.UpdatedAt,
                OrderItems = dto.OrderItems
            };
        }

    }
}
