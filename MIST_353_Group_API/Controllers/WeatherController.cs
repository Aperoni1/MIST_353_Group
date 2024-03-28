using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Repositories;

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
        [HttpGet("WeatherStatus/{LocationID}")]
        public async Task<IActionResult> GetWeatherByID(int LocationID)
        {
            var weather = await weatherService.GetWeatherByLocation(LocationID);

            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }

        // Park status by LocationID 
        [HttpGet("ParkStatus/{LocationID}")]
        public async Task<IActionResult> GetParkStatus(int LocationID)
        {
            var parkStatus = await weatherService.GetParkStatus(LocationID);

            if (parkStatus == null)
            {
                return NotFound();
            }

            return Ok(parkStatus);
        }
    }
}