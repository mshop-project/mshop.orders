using MassTransit;
using Microsoft.Extensions.DependencyInjection;
using mshop.orders.domain.Repositories;
using mshop.orders.infrastructure.Repositiories;

namespace mshop.orders.infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            return services.AddSingleton<OrderDbContext>()
                .AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
