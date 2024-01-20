using MediatR;
using mshop.orders.application.DTOs;
namespace mshop.orders.application.Orders.GetOrders
{
    record GetOrdersByEmailQuery(string email) : IRequest<IEnumerable<OrderDto>>;
}
