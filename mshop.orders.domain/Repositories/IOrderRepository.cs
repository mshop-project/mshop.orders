using mshop.orders.domain.Entities;

namespace mshop.orders.domain.Repositories
{
    public interface IOrderRepository
    {
        public void CreateOrder(Order order);
        public List<Order> GetOrdersByEmail(string email);
    }
}
