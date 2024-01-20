using mshop.orders.domain.Entities;
using mshop.orders.domain.Repositories;

namespace mshop.orders.infrastructure.Repositiories
{
    public sealed class OrderRepository : IOrderRepository
    {
        public void CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrdersByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
