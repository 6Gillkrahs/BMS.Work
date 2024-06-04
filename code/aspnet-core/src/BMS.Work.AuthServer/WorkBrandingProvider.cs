using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace BMS.Work;

[Dependency(ReplaceServices = true)]
public class WorkBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Work";
}
