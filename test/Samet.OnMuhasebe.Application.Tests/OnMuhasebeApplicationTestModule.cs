using Volo.Abp.Modularity;

namespace Samet.OnMuhasebe;

[DependsOn(
    typeof(OnMuhasebeApplicationModule),
    typeof(OnMuhasebeDomainTestModule)
)]
public class OnMuhasebeApplicationTestModule : AbpModule
{

}
