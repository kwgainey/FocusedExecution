using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace FocusedExecution
{
    [Dependency(ReplaceServices = true)]
    public class FocusedExecutionBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "FocusedExecution";
    }
}
