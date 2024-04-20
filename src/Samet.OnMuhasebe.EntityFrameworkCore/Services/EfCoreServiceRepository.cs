using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Services;

public class EfCoreServiceRepository : EfCoreCommonRepository<Service>, IServiceRepository
{
    public EfCoreServiceRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}