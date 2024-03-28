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

        // API to Get Weather by ID
        [HttpGet("WeatherStatus/{WeatherID}")]
        public async Task<IActionResult> GetWeatherByID(int WeatherID)
        {
            var weather = await weatherService.CarterProctorSP3(WeatherID);

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
            var parkStatus = await weatherService.CarterProctorSPs(LocationID);

            if (parkStatus == null)
            {
                return NotFound();
            }

            return Ok(parkStatus);
        }
    }
}