using MediatR;
using mshop.orders.application.DTOs;
namespace mshop.orders.application.Orders.GetOrders
{
    public sealed record GetOrdersByEmailQuery(string Email) : IRequest<IEnumerable<OrderDto>>;
}
