using Microsoft.AspNetCore.Mvc;
using Tkachivskyi.University.UkrainItch.Core.Interfaces;
using Tkachivskyi.University.UkrainItch.Models.Weather;

namespace Tkachivskyi.University.UkrainItch.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _forecastService;

        public WeatherForecastController(IWeatherForecastService forecastService)
        {
            _forecastService = forecastService;
        }

        [HttpGet]
        [Route("Get")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _forecastService.GetRandomForecast();
        }
    }
}