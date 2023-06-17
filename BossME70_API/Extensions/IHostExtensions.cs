namespace BossME70_API.Extensions;

public static class IHostExtensions
{
    public static IHost MigrateDatabase(this IHost host)
    {
        try
        {
            using var scope = host.Services.CreateScope();
            using var contexto = scope.ServiceProvider.GetRequiredService<Context.BossDbContext>();

            contexto.Database.Migrate();
        }
        catch (Exception)
        {
            //throw;
        }

        return host;
    }
}
