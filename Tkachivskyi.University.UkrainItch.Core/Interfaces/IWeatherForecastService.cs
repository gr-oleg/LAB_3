using Tkachivskyi.University.UkrainItch.Models.Weather;

namespace Tkachivskyi.University.UkrainItch.Core.Interfaces
{
    public interface IWeatherForecastService
    {
        IEnumerable<WeatherForecast> GetRandomForecast();
    }
}
