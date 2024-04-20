using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.BankAccounts;

public class EfCoreBankAccountRepository : EfCoreCommonRepository<BankAccount>, IBankAccountRepository
{
    public EfCoreBankAccountRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}