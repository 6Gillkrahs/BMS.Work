using BMS.Work.Samples;
using Xunit;

namespace BMS.Work.EntityFrameworkCore.Applications;

[Collection(WorkTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<WorkEntityFrameworkCoreTestModule>
{

}
