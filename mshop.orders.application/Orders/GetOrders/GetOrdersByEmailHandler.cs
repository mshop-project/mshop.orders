using MediatR;
using mshop.orders.application.DTOs;
using mshop.orders.domain.Repositories;

namespace mshop.orders.application.Orders.GetOrders
{
    internal class GetOrdersByEmailHandler : IRequestHandler<GetOrdersByEmailQuery, IEnumerable<OrderDto>>
    {
        private readonly IOrderRepository _orderRepository;

        public GetOrdersByEmailHandler(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public async Task<IEnumerable<OrderDto>> Handle(GetOrdersByEmailQuery request, CancellationToken cancellationToken)
        {
           var orders = await _orderRepository.GetAsync(request.Email); 

            return orders.Select(ord  
                => new OrderDto { 
                    Id = ord.Id, 
                    ClientEmail = ord.ClientEmail,
                    DiscountPercentage = ord.DiscountPercentage,
                    IdProducts = ord.IdProducts,
                    TotalPriceAfterDiscount = ord.TotalPriceAfterDiscount,
                    TotalPriceBeforeDiscount = ord.TotalPriceBeforeDiscount
                });
        }
    }
}
