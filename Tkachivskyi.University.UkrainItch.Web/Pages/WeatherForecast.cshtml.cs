using Microsoft.AspNetCore.Mvc.RazorPages;
using Tkachivskyi.University.UkrainItch.Core.Interfaces;
using Tkachivskyi.University.UkrainItch.Models.Weather;

namespace Tkachivskyi.University.UkrainItch.Web.Pages
{
    public class WeatherForecastModel : PageModel
    {
        public IList<WeatherForecast> Forecasts { get; set; }

        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastModel(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public void OnGet()
        {
            Forecasts = _weatherForecastService.GetRandomForecast().ToList();
        }
    }
}