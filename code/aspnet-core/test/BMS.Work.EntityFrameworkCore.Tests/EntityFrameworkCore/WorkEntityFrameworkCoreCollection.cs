using Xunit;

namespace BMS.Work.EntityFrameworkCore;

[CollectionDefinition(WorkTestConsts.CollectionDefinitionName)]
public class WorkEntityFrameworkCoreCollection : ICollectionFixture<WorkEntityFrameworkCoreFixture>
{

}
