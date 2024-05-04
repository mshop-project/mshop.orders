using MediatR;
using mshop.orders.domain.Repositories;
using mshop.sharedkernel.coredata.Orders;

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
                IdProducts = [.. data.IdProducts!],
                ClientEmail = data.ClientEmail!,
                TotalPriceBeforeDiscount = (decimal)data.TotalPriceBeforeDiscount!,
                TotalPriceAfterDiscount = (decimal)data.TotalPriceAfterDiscount!,
                DiscountPercentage = (decimal)data.DiscountPercentage!
            });
        }
    }
}
