using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_Pages.Pages
{
    public class StateWeatherModel : PageModel
    {
        public readonly IStateWeatherService _StateWeatherService;
        public StateWeatherModel(IStateWeatherService StateWeatherService)
        {
            _StateWeatherService = StateWeatherService;
        }

        public async Task<IActionResult> OnGet(string State)
        {
            if (string.IsNullOrEmpty(State))
            {
                return Page();
            }
            var stateWeather = await _StateWeatherService.GetWeatherByState(State);

            if (stateWeather == null)
            {
                return Page();
            }
            ViewData["StateWeatherData"] = stateWeather;
            return Page();
        }
    }
}
