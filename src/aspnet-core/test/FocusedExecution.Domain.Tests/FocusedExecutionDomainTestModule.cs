using FocusedExecution.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace FocusedExecution
{
    [DependsOn(
        typeof(FocusedExecutionEntityFrameworkCoreTestModule)
        )]
    public class FocusedExecutionDomainTestModule : AbpModule
    {

    }
}