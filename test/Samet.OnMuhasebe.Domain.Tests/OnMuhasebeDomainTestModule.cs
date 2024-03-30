using Volo.Abp.Modularity;

namespace Samet.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeDomainModule),
    typeof(OnMuhasebeTestBaseModule)
)]
public class OnMuhasebeDomainTestModule : AbpModule
{

}
