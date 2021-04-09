using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace FocusedExecution.Data
{
    /* This is used if database provider does't define
     * IFocusedExecutionDbSchemaMigrator implementation.
     */
    public class NullFocusedExecutionDbSchemaMigrator : IFocusedExecutionDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}