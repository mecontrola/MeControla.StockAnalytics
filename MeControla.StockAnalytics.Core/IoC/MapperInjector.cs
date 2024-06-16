using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MeControla.StockAnalytics.Core.IoC
{
    internal static class MapperInjector
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.TryAddSingleton<IBrokerEntityToDtoMapper, BrokerEntityToDtoMapper>();
            services.TryAddSingleton<ICompanyEntityToDtoMapper, CompanyEntityToDtoMapper>();
            services.TryAddSingleton<IRegisterEntityToDtoMapper, RegisterEntityToDtoMapper>();
            services.TryAddSingleton<IWalletEntityToDtoMapper, WalletEntityToDtoMapper>();

            services.TryAddSingleton<IBrokerInputDtoToFilterEntityMapper, BrokerInputDtoToFilterEntityMapper>();
            services.TryAddSingleton<ICompanyInputDtoToFilterEntityMapper, CompanyInputDtoToFilterEntityMapper>();
            services.TryAddSingleton<IRegisterInputDtoToFilterEntityMapper, RegisterInputDtoToFilterEntityMapper>();
            services.TryAddSingleton<IWalletInputDtoToFilterEntityMapper, WalletInputDtoToFilterEntityMapper>();

            return services;
        }
    }
}