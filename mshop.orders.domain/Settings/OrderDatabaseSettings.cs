namespace mshop.orders.domain.Settings
{
    public class OrderDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string OrdersCollectionName { get; set; } = null!;
    }
}
