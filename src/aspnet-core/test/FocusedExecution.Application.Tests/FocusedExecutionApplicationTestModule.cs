using Volo.Abp.Modularity;

namespace FocusedExecution
{
    [DependsOn(
        typeof(FocusedExecutionApplicationModule),
        typeof(FocusedExecutionDomainTestModule)
        )]
    public class FocusedExecutionApplicationTestModule : AbpModule
    {

    }
}