using Microsoft.Extensions.Options;
using Tkachivskyi.University.UkrainItch.Core.Constants;
using Tkachivskyi.University.UkrainItch.Core.Interfaces;
using Tkachivskyi.University.UkrainItch.Models.Configuration;
using Tkachivskyi.University.UkrainItch.Models.Weather;

namespace Tkachivskyi.University.UkrainItch.Core.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IOptions<AppConfig> _configuration;

        public WeatherForecastService(IOptions<AppConfig> configuration)
        {
            _configuration = configuration;
        }

        public IEnumerable<WeatherForecast> GetRandomForecast()
        {
            var amount = _configuration?.Value?.ForecastAmount ?? 1;

            return Enumerable.Range(1, amount).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = GetRandomSummary()
            })
            .ToArray();
        }

        private string GetRandomSummary()
        {
            return ProjectConstants.WeatherSummaries[Random.Shared.Next(ProjectConstants.WeatherSummaries.Length)];
        }
    }
}
