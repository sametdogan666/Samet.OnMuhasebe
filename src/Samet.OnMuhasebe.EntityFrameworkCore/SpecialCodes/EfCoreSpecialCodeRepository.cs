using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.SpecialCodes;

public class EfCoreSpecialCodeRepository : EfCoreCommonRepository<SpecialCode>, ISpecialCodeRepository
{
    public EfCoreSpecialCodeRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}