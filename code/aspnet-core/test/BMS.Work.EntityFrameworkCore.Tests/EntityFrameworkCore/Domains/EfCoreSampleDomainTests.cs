using BMS.Work.Samples;
using Xunit;

namespace BMS.Work.EntityFrameworkCore.Domains;

[Collection(WorkTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<WorkEntityFrameworkCoreTestModule>
{

}
