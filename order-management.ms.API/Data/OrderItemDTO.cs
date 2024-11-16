using System.Text.Json;

namespace order_management.ms.API.Data
{
    public class OrderItemDTO
    {
        public int OrderId { get; set; }
        public double TotalAmount { get; set; }
        public string OrderStatus { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public JsonDocument OrderItems { get; set; }
    }
}
