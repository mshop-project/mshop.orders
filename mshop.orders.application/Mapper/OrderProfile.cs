using AutoMapper;
using mshop.orders.application.DTOs;
using mshop.sharedkernel.coredata.Orders;

namespace mshop.orders.application.Mapper
{
    public class OrderProfile : Profile
    {
        public OrderProfile()
        {
            CreateMap<OrderDto, Order>();
            CreateMap<Order, OrderDto>();
        }
    }
}
