using MeControla.Core.Builders;
using MeControla.StockAnalytics.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Core.Builders
{
#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyBuilder : BaseBuilder<CompanyBuilder, Company>, IBuilder<Company>
    {
        protected override void FillDefaultValues(Company obj)
        {
            obj.Uuid = Guid.NewGuid();
            obj.CreatedAt = DateTime.Now;
        }
    }
}