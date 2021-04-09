using System.Threading.Tasks;

namespace FocusedExecution.Data
{
    public interface IFocusedExecutionDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
