using Volo.Abp.Modularity;

namespace BMS.Work;

public abstract class WorkApplicationTestBase<TStartupModule> : WorkTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
