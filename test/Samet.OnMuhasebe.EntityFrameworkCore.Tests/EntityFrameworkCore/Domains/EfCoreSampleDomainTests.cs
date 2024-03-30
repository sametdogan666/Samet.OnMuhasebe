using Samet.OnMuhasebe.Samples;
using Xunit;

namespace Samet.OnMuhasebe.EntityFrameworkCore.Domains;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
