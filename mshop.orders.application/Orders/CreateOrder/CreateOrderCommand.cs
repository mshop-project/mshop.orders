using MediatR;
using mshop.orders.application.DTOs;
namespace mshop.orders.application.Orders.CreateOrder
{
record CreateOrderCommand(OrderDto orderDto) : IRequest;
}
