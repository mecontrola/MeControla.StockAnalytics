using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.IBrokerBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface IBrokerBusiness : IBaseFormViewModelBusiness<BrokerDto, BrokerInputDto>, IBaseListViewModelBusiness<BrokerDto, BrokerFilterInputDto>
    { }

    public class BrokerBusiness(CoreBusiness business) : IBrokerBusiness
    {
        public async Task<IList<BrokerDto>> GetFilterAllAsync(BrokerFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await business.SwitchAtiveInactiveAsync(id, cancellationToken);

        public async Task<BrokerDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, BrokerInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);
    }
}