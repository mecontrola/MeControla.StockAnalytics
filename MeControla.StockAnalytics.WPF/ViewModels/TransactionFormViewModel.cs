using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.Inputs;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class TransactionFormViewModel
    {

        protected void FillForm(TransactionDto entity)
        {
            Amount = entity?.Amount ?? 0;
            Price = entity?.Price ?? 0;
            Total = entity?.Total ?? 0;
        }

        protected TransactionInputDto FillInputDto()
            => new()
            {
                Amount = Amount,
                Price = Price,
                Total = Total,
            };
    }
}