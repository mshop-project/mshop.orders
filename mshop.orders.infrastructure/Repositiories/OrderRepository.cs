using MongoDB.Driver;
using mshop.orders.domain.Entities;
using mshop.orders.domain.Repositories;

namespace mshop.orders.infrastructure.Repositiories
{
    public sealed class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _orderDbContext;
        public OrderRepository(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public async Task<List<Order>> GetAsync(string clientEmail) =>
            await _orderDbContext.OrdersCollection.Find(x => x.ClientEmail == clientEmail).ToListAsync();

        public async Task CreateAsync(Order newBook) =>
            await _orderDbContext.OrdersCollection.InsertOneAsync(newBook);

    }
}
