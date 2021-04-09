using FocusedExecution.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace FocusedExecution.Permissions
{
    public class FocusedExecutionPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(FocusedExecutionPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(FocusedExecutionPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<FocusedExecutionResource>(name);
        }
    }
}
