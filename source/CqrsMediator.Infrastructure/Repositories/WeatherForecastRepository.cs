using CqrsMediator.Domain.Contracts.Repositories;
using CqrsMediator.Domain.Entities;
using CqrsMediator.Infrastructure.Data;

namespace CqrsMediator.Infrastructure.Repositories;

public class WeatherForecastRepository : Repository<WeatherForecast>, IWeatherForecastRepository
{
    public WeatherForecastRepository(ApplicationDbContext dbContext) : base(dbContext)
    {

    }
}
