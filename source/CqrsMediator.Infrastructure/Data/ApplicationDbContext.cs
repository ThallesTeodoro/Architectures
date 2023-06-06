using CqrsMediator.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CqrsMediator.Infrastructure.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }
}
