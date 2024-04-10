using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Repositories;
using System.Threading.Tasks;

namespace MIST_353_Group_Pages.Pages
{
    public class WeatherByLocationIDModel : PageModel
    {
        private readonly IWeatherService _weatherService;

        public WeatherByLocationIDModel(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> OnGet(int? locationID)
        {
            if (!locationID.HasValue)
            {
                // Handle case where location ID is not provided
                return Page();
            }

            // Call WeatherService to get weather data by location ID
            var weather = await _weatherService.GetWeatherByLocation(locationID.Value);

            if (weather == null)
            {
                // Handle case where weather data is not found
                return Page();
            }

            // Pass weather data to the Razor Page
            ViewData["WeatherData"] = weather;

            return Page();
        }
    }
}
