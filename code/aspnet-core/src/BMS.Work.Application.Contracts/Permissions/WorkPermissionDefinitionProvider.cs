using BMS.Work.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace BMS.Work.Permissions;

public class WorkPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(WorkPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(WorkPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<WorkResource>(name);
    }
}
