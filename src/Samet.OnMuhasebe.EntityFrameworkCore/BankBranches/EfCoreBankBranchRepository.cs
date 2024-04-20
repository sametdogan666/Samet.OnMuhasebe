using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.BankBranches;

public class EfCoreBankBranchRepository : EfCoreCommonRepository<BankBranch>, IBankBranchRepository
{
    public EfCoreBankBranchRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}