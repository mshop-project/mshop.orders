using MassTransit;
using mshop.orders.api.BusHandlers;
using mshop.orders.application;
using mshop.orders.domain.Settings;
using mshop.orders.infrastructure;

namespace mshop.orders.api
{
    public static class Extensions
    {
        public static IServiceCollection AddOrdersExtensions(this IServiceCollection services, IConfiguration configuration)
        {
            return services.Configure<OrderDatabaseSettings>(configuration.GetSection("OrderDatabase"))
                .AddApplication()
                .AddInfrastructure(); 
        }

        public static IBusRegistrationConfigurator AddOrdersBusConfig(this IBusRegistrationConfigurator config)
        {
            config.AddConsumer<GetOrdersByEmailConsumer>();
            return config;
        }
    }
}