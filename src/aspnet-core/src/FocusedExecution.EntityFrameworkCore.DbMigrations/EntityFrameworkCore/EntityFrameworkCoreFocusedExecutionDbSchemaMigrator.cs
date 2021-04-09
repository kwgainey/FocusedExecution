using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FocusedExecution.Data;
using Volo.Abp.DependencyInjection;

namespace FocusedExecution.EntityFrameworkCore
{
    public class EntityFrameworkCoreFocusedExecutionDbSchemaMigrator
        : IFocusedExecutionDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreFocusedExecutionDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the FocusedExecutionMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<FocusedExecutionMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}