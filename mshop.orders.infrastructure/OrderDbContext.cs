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
        IOptions<OrderDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            _database = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            OrdersCollection = _database.GetCollection<Order>(
            bookStoreDatabaseSettings.Value.BooksCollectionName);
        }

   
    }
}
