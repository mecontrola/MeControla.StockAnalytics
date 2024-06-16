using MeControla.StockAnalytics.DataStorage.IoC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MeControla.StockAnalytics.Core.IoC
{
    public static class CoreInjector
    {
        public static IServiceCollection AddCoreInjectors(this IServiceCollection services, IConfiguration configuration)
            => services.AddRepositories(configuration)
                       .AddBusiness()
                       .AddMappers()
                       .AddServices()
                       .AddValidators();
    }
}