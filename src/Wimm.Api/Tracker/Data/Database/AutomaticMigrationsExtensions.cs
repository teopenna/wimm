using Microsoft.EntityFrameworkCore;

namespace Wimm.Api.Tracker.Data.Database;

internal static class AutomaticMigrationsExtensions
{
    internal static IApplicationBuilder UseAutomaticMigrations(this IApplicationBuilder applicationBuilder)
    {
        using var scope = applicationBuilder.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<TrackerPersistence>();
        context.Database.Migrate();
        
        return applicationBuilder;
    }
}