﻿using Volo.Abp.Modularity;

namespace BMS.Work;

[DependsOn(
    typeof(WorkApplicationModule),
    typeof(WorkDomainTestModule)
)]
public class WorkApplicationTestModule : AbpModule
{

}
