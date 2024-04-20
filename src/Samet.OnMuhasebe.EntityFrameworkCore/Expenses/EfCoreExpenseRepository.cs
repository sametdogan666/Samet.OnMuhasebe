using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Expenses;

public class EfCoreExpenseRepository : EfCoreCommonRepository<Expense>, IExpenseRepository
{
    public EfCoreExpenseRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}