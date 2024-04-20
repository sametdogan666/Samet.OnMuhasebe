using Samet.OnMuhasebe.Bills;
using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Invoices;

public class EfCoreInvoiceRepository : EfCoreCommonRepository<Invoice>, IInvoiceRepository
{
    public EfCoreInvoiceRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}