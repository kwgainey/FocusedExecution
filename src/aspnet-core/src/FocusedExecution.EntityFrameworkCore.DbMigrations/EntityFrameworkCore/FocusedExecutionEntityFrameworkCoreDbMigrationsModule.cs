using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace FocusedExecution.EntityFrameworkCore
{
    [DependsOn(
        typeof(FocusedExecutionEntityFrameworkCoreModule)
        )]
    public class FocusedExecutionEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<FocusedExecutionMigrationsDbContext>();
        }
    }
}
