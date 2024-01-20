using MediatR;
using MongoDB.Driver;
using mshop.orders.domain.Entities;
using mshop.orders.domain.Repositories;

namespace mshop.orders.application.Orders.CreateOrder
{
    internal sealed class CreateOrderHandler : IRequestHandler<CreateOrderCommand>
    {
        private readonly IOrderRepository _orderRepository;

        public CreateOrderHandler(IOrderRepository orderRepository)
        {
            this._orderRepository = orderRepository;
        }

        public async Task Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var data = request.orderDto;
            await _orderRepository.CreateAsync(new Order
            {
                IdProducts = data.IdProducts!.ToList(),
                ClientEmail = data.ClientEmail!,
                TotalPriceBeforeDiscount = (decimal)data.TotalPriceBeforeDiscount!,
                TotalPriceAfterDiscount = (decimal)data.TotalPriceAfterDiscount!,
                DiscountPercentage = (decimal)data.DiscountPercentage!
            });
        }
    }
}
