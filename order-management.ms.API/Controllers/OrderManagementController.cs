using Microsoft.AspNetCore.Mvc;
using order_management.ms.API.Data;
using order_management.ms.API.Service;

namespace order_management.ms.API.Controllers
{
    [Route("api")]
    [ApiController]
    public class OrderManagementController : ControllerBase
    {
        private readonly OrderManagementService _orderManagementService;
        public OrderManagementController(OrderManagementService orderManagementService)
        {
            _orderManagementService = orderManagementService;
        }

        [HttpPost("validate-order")]
        public async Task<Boolean> ValidateOrder([FromBody] OrderItemDTO orderItemDTO) 
        {
            return await Task.FromResult(_orderManagementService.ValidateOrder(orderItemDTO));
        }

        [HttpPost("save-order")]
        public async Task<Boolean> SaveOrderInDatabase([FromBody] OrderItemDTO orderItemDTO)
        {
            await _orderManagementService.SaveOrder(orderItemDTO);
            return true;
        }
    }
}
