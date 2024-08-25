using MassTransit;
using MediatR;
using mshop.orders.application.Orders.GetOrders;
using mshop.sharedkernel.coredata.Orders;
using mshop.sharedkernel.messaging.Data.Request.Orders;
using mshop.sharedkernel.messaging.Data.Response.Orders;

namespace mshop.orders.api.BusHandlers
{
    public sealed class GetOrdersByEmailConsumer(IMediator _mediator) : IConsumer<GetOrdersByEmailRequest>
    {
        public async Task Consume(ConsumeContext<GetOrdersByEmailRequest> context)
        {
            var ordersResponse = new OrdersResponse();

            var ordersDto = await _mediator.Send(new GetOrdersByEmailQuery(context.Message.Email));

            var orders = ordersDto.Select(orderDto => new Order
            {
                Id = orderDto.Id,
                ClientEmail = orderDto.ClientEmail!,
                DiscountPercentage = (decimal)orderDto.DiscountPercentage!,
                IdProducts = orderDto.IdProducts!,
                TotalPriceAfterDiscount = (decimal)orderDto.TotalPriceAfterDiscount!,
                TotalPriceBeforeDiscount = (decimal)orderDto.TotalPriceBeforeDiscount!
            });

            ordersResponse.Orders.AddRange(orders);

            await context.RespondAsync(ordersResponse);
        }
    }
}