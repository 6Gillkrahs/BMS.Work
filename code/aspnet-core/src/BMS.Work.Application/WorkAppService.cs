using System;
using System.Collections.Generic;
using System.Text;
using BMS.Work.Localization;
using Volo.Abp.Application.Services;

namespace BMS.Work;

/* Inherit your application services from this class.
 */
public abstract class WorkAppService : ApplicationService
{
    protected WorkAppService()
    {
        LocalizationResource = typeof(WorkResource);
    }
}
