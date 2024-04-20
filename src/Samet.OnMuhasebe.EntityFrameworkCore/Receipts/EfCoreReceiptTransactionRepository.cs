using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Receipts;

public class EfCoreReceiptTransactionRepository : EfCoreCommonRepository<ReceiptTransaction>, IReceiptTransactionRepository
{
    public EfCoreReceiptTransactionRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}