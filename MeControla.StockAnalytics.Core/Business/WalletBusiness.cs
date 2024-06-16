using MeControla.StockAnalytics.Core.Services;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Business
{
    public interface IWalletBusiness
    {
        Task<IList<WalletDto>> RetrieveFilterListAsync(WalletFilterInputDto filterInputDto, CancellationToken cancellationToken);
        Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken);
        Task<WalletDto> GetAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> SaveAsync(Guid? id, WalletInputDto input, CancellationToken cancellationToken);
    }

    public class WalletBusiness(IWalletRetrieveFilterListService walletRetrieveFilterListService,
                                IWalletRetrieveService walletRetrieveService,
                                IWalletSaveService walletSaveService,
                                IWalletSwitchAtiveInactiveService walletSwitchAtiveInactiveService)
        : IWalletBusiness
    {
        public async Task<IList<WalletDto>> RetrieveFilterListAsync(WalletFilterInputDto filterInputDto, CancellationToken cancellationToken)
            => await walletRetrieveFilterListService.GetFilterListAsync(filterInputDto, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await walletSwitchAtiveInactiveService.SwitchStatusAsync(id, cancellationToken);

        public async Task<WalletDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await walletRetrieveService.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, WalletInputDto input, CancellationToken cancellationToken)
            => await walletSaveService.SaveAsync(id, input, cancellationToken);
    }
}