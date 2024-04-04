using CardSort.Database;
using CardSort.services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CardSort;

partial class App
{
    private IServiceProvider? _serviceProvider;

    public static IServiceProvider Services
    {
        get
        {
            var serviceProvider = ((App)Current)._serviceProvider
                                  ?? throw new InvalidOperationException(
                                      "The service provider is not initialized");
            return serviceProvider;
        }
    }

    private static ServiceProvider ConfigureServices()
    {
        var provider = new ServiceCollection()
            .AddSingleton<IDbService, DbService>()
            .AddSingleton<DbContext, CardSortContext>()
            .BuildServiceProvider(true);

        return provider;
    }
}