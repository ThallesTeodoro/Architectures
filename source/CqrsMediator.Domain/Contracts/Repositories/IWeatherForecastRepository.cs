using CqrsMediator.Domain.Entities;

namespace CqrsMediator.Domain.Contracts.Repositories;

public interface IWeatherForecastRepository : IRepository<WeatherForecast>
{
}
