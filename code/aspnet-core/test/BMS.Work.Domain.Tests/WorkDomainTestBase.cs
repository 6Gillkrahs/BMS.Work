using Volo.Abp.Modularity;

namespace BMS.Work;

/* Inherit from this class for your domain layer tests. */
public abstract class WorkDomainTestBase<TStartupModule> : WorkTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
