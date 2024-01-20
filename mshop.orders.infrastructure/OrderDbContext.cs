using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using mshop.orders.domain.Entities;
namespace mshop.orders.infrastructure
{
    public class OrderDbContext
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<Order> _ordersCollection;

        public OrderDbContext(
        IOptions<OrderDatabaseSettings> bookStoreDatabaseSettings)
        {
            var mongoClient = new MongoClient(
                bookStoreDatabaseSettings.Value.ConnectionString);

            _database = mongoClient.GetDatabase(
                bookStoreDatabaseSettings.Value.DatabaseName);

            _ordersCollection = _database.GetCollection<Order>(
            bookStoreDatabaseSettings.Value.BooksCollectionName);
        }

        public async Task<List<Order>> GetAsync() =>
            await _ordersCollection.Find(_ => true).ToListAsync();

        public async Task<Order?> GetAsync(string id) =>
            await _ordersCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

        public async Task CreateAsync(Order newBook) =>
            await _ordersCollection.InsertOneAsync(newBook);

        public async Task UpdateAsync(string id, Order updatedBook) =>
            await _ordersCollection.ReplaceOneAsync(x => x.Id == id, updatedBook);

        public async Task RemoveAsync(string id) =>
            await _ordersCollection.DeleteOneAsync(x => x.Id == id);
    }
}
