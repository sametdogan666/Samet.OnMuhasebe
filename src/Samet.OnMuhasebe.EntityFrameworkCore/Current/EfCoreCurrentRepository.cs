using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.Currents;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Current;

public class EfCoreCurrentRepository : EfCoreCommonRepository<Currents.Current>, ICurrentRepository
{
    public EfCoreCurrentRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}