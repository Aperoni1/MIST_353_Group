using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Entities;
using MIST_353_Group_API.Repositories;
using System.Collections.Generic;
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

        [HttpGet("{WeatherID}")]
        public async Task<IActionResult> CarterProctorSPs(int WeatherID)
        {
            var humidityDetails = await weatherService.CarterProctorSPs(WeatherID);

            if (humidityDetails == null)
            {
                return NotFound();
            }

            return Ok(humidityDetails);
        }
    }
}
