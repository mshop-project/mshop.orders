using Microsoft.Extensions.DependencyInjection;
using mshop.orders.domain.Repositories;
using mshop.orders.infrastructure.Repositiories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
