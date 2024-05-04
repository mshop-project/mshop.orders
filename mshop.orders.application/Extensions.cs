using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using mshop.orders.application.Mapper;

namespace mshop.orders.application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            var assembly = typeof(Extensions).Assembly;
            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssemblies(assembly);
            });

            services.AddScoped(provider => new MapperConfiguration(cfg =>
            {
                using var scope = provider.CreateScope();
                cfg.AddProfile(new OrderProfile());
            }).CreateMapper());

            return services;
        }
    }
}
