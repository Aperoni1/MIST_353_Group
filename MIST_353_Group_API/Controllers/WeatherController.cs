using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Repositories;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService weatherService;

        public WeatherController(IWeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        // API to Get Weather by Location
        [HttpGet("Weather by Location/{LocationID}")]
        public async Task<IActionResult> GetWeatherByID(int LocationID)
        {
            var weather = await weatherService.GetWeatherByLocation(LocationID);

            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }

        // API to Get Weather by Park Name
        [HttpGet("Weather By Park Name")]
        public async Task<IActionResult> GetWeatherByParkName([FromQuery] string parkName)
        {
            var weather = await weatherService.GetWeatherByParkName(parkName);

            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }
    }
}
