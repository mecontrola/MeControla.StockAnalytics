using MeControla.Core.Data.Dtos;

namespace MeControla.StockAnalytics.Data.Dtos.Inputs
{
    public class TransactionInputDto : IInputDto
    {
        public long Amount { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
    }
}