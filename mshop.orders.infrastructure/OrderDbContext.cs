using MongoDB.Driver;
using Microsoft.Extensions.Options;
using mshop.orders.domain.Entities;
namespace mshop.orders.infrastructure
{
    public class OrderDbContext
    {
        private readonly IMongoDatabase _database;
        public IMongoCollection<Order> OrdersCollection { get; set; }

        public OrderDbContext(
        IOptions<OrderDatabaseSettings> orderDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                orderDatabaseSettings.Value.ConnectionString);

            _database = mongoClient.GetDatabase(
                orderDatabaseSettings.Value.DatabaseName);

            OrdersCollection = _database.GetCollection<Order>(
            orderDatabaseSettings.Value.OrdersCollectionName);
        }

   
    }
}
