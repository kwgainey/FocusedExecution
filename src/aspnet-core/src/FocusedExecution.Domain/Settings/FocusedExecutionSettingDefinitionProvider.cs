using Volo.Abp.Settings;

namespace FocusedExecution.Settings
{
    public class FocusedExecutionSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FocusedExecutionSettings.MySetting1));
        }
    }
}
