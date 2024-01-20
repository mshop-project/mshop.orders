using Microsoft.AspNetCore.Mvc;
using mshop.orders.application.DTOs;
using MediatR;
using mshop.orders.application.Orders.GetOrders;
using mshop.orders.application.Orders.CreateOrder;
namespace mshop.orders.api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{email}")]
        public async Task<IActionResult> GetOrders([FromRoute] string email)
        {
            var result = await _mediator.Send(new GetOrdersByEmailQuery(email));

            return Ok(result);
        }

        [HttpPost("")]
        public async Task<IActionResult> CreateOrder([FromBody] OrderDto orderDto)
        {
            await _mediator.Send(new CreateOrderCommand(orderDto));

            return Ok();
        }
    }
}
