using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeControla.StockAnalytics.DataStorage
{
    public interface IDbAppContext : IDbContext
    {
        DbSet<Broker> Brokers { get; }
        DbSet<Company> Companies { get; }
        DbSet<Register> Registers { get; }
        DbSet<Ticker> Tickers { get; }
        DbSet<Wallet> Wallets { get; }
    }
}