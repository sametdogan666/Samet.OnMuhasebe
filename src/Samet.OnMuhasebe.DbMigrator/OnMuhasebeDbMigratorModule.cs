﻿using Samet.OnMuhasebe.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Samet.OnMuhasebe.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(OnMuhasebeEntityFrameworkCoreModule),
    typeof(OnMuhasebeApplicationContractsModule)
    )]
public class OnMuhasebeDbMigratorModule : AbpModule
{
}
