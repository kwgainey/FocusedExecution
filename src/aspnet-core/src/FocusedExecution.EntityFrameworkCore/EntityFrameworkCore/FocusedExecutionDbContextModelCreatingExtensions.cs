using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace FocusedExecution.EntityFrameworkCore
{
    public static class FocusedExecutionDbContextModelCreatingExtensions
    {
        public static void ConfigureFocusedExecution(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(FocusedExecutionConsts.DbTablePrefix + "YourEntities", FocusedExecutionConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}