using MediatR;
using mshop.orders.application.DTOs;
namespace mshop.orders.application.Orders.CreateOrder
{
    public sealed record CreateOrderCommand(OrderDto orderDto) : IRequest;
}
