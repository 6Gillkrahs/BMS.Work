using Volo.Abp.Modularity;

namespace BMS.Work;

[DependsOn(
    typeof(WorkDomainModule),
    typeof(WorkTestBaseModule)
)]
public class WorkDomainTestModule : AbpModule
{

}
