using mshop.sharedkernel.coredata.Orders;

namespace mshop.orders.domain.Repositories
{
    public interface IOrderRepository
    {
        public Task<List<Order>> GetAsync(string clientEmail);

        public Task CreateAsync(Order newBook);
    }
}
