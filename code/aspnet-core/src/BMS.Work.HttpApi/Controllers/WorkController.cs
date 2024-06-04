using BMS.Work.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace BMS.Work.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class WorkController : AbpControllerBase
{
    protected WorkController()
    {
        LocalizationResource = typeof(WorkResource);
    }
}
