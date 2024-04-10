using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_Pages.Pages
{
    public class ParkWeatherModel : PageModel
    {
        public readonly IWeatherService _weatherService;

        public ParkWeatherModel(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> OnGet(string parkName)
        {
            if (string.IsNullOrEmpty(parkName))
            {
                // Handle case where park name is not provided
                return Page();
            }

            // Call WeatherService to get weather data by park name
            var weather = await _weatherService.GetWeatherByParkName(parkName);

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
