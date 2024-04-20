using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Receipts;

public class EfCoreReceiptRepository : EfCoreCommonRepository<Receipt>, IReceiptRepository
{
    public EfCoreReceiptRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}