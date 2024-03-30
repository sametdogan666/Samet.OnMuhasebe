using Volo.Abp.Modularity;

namespace Samet.OnMuhasebe;

public abstract class OnMuhasebeApplicationTestBase<TStartupModule> : OnMuhasebeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
