﻿using MeControla.StockAnalytics.Core.Business;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System;

namespace MeControla.StockAnalytics.Core.IoC
{
    internal static class BusinessInjector
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            ArgumentNullException.ThrowIfNull(services);

            services.TryAddScoped<IBrokerBusiness, BrokerBusiness>();
            services.TryAddScoped<ICompanyBusiness, CompanyBusiness>();
            services.TryAddScoped<IRegisterBusiness, RegisterBusiness>();
            services.TryAddScoped<IWalletBusiness, WalletBusiness>();

            return services;
        }
    }
}