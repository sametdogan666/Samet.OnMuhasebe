using Samet.OnMuhasebe.Samples;
using Xunit;

namespace Samet.OnMuhasebe.EntityFrameworkCore.Applications;

[Collection(OnMuhasebeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<OnMuhasebeEntityFrameworkCoreTestModule>
{

}
