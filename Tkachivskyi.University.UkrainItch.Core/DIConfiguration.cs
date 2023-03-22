using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tkachivskyi.University.UkrainItch.Core.Interfaces;
using Tkachivskyi.University.UkrainItch.Core.Services;
using Tkachivskyi.University.UkrainItch.Models.Configuration;

namespace Tkachivskyi.University.UkrainItch.Core
{
    public static class DIConfiguration
    {
        public static void RegisterCoreDependencies(this IServiceCollection services)
        {
            services.AddTransient<IWeatherForecastService, WeatherForecastService>();
        }

        public static void RegisterCoreConfiguration(this IServiceCollection services, IConfigurationRoot configuration)
        {
            services.Configure<AppConfig>(configuration.GetSection("AppConfig"));
        }
    }
}
