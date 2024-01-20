using Microsoft.AspNetCore.Mvc;
using mshop.orders.application.DTOs;

namespace mshop.orders.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet("")]
        public IActionResult GetOrders([FromBody] OrderDto orderDto)
        {
            return Ok("hey"); 
        }
    }
}
