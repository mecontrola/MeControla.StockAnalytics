using MeControla.Core.Repositories;
using MeControla.StockAnalytics.Data.Entities;

namespace MeControla.StockAnalytics.DataStorage.Repositories
{
    public interface ITickerRepository : IAsyncRepository<Ticker>
    { }

    public sealed class TickerRepository(IDbAppContext context) : BaseAsyncRepository<Ticker>(context, context.Tickers), ITickerRepository
    { }
}