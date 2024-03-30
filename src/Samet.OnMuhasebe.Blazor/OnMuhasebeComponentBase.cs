using Samet.OnMuhasebe.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Samet.OnMuhasebe.Blazor;

public abstract class OnMuhasebeComponentBase : AbpComponentBase
{
    protected OnMuhasebeComponentBase()
    {
        LocalizationResource = typeof(OnMuhasebeResource);
    }
}
