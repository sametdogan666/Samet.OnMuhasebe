using Samet.OnMuhasebe.Bills;
using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Invoices;

public class EfCoreInvoiceTransactionRepository : EfCoreCommonRepository<InvoiceTransaction>, IInvoiceTransactionRepository
{
    public EfCoreInvoiceTransactionRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}