using CqrsMediator.Domain.Contracts.Persistence;
using CqrsMediator.Domain.Contracts.Repositories;
using CqrsMediator.Infrastructure.Data;
using CqrsMediator.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CqrsMediator.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContextSettings(configuration);

        services.AddTransient<IUnitOfWork, UnitOfWork>();
        services.AddTransient<IWeatherForecastRepository, WeatherForecastRepository>();

        return services;
    }

    private static IServiceCollection AddDbContextSettings(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("ApplicationContext");

        services.AddDbContextPool<ApplicationDbContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        return services;
    }
}
