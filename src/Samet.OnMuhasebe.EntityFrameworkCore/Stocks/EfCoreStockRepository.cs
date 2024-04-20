using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Stocks;

public class EfCoreStockRepository : EfCoreCommonRepository<Stock>, IStockRepository
{
    public EfCoreStockRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}