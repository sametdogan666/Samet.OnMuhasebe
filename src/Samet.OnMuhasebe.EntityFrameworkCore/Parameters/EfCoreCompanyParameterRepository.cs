using Samet.OnMuhasebe.Commons;
using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Samet.OnMuhasebe.Parameters;

public class EfCoreCompanyParameterRepository : EfCoreCommonRepository<CompanyParameter>, ICompanyParameterRepository
{
    public EfCoreCompanyParameterRepository(IDbContextProvider<OnMuhasebeDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }
}