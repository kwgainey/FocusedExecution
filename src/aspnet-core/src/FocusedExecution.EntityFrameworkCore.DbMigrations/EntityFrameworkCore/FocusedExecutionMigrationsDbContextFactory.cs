using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace FocusedExecution.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class FocusedExecutionMigrationsDbContextFactory : IDesignTimeDbContextFactory<FocusedExecutionMigrationsDbContext>
    {
        public FocusedExecutionMigrationsDbContext CreateDbContext(string[] args)
        {
            FocusedExecutionEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<FocusedExecutionMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new FocusedExecutionMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../FocusedExecution.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
