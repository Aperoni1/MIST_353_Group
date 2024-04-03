using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Entities;
using MIST_353_Group_API.Repositories;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StateWeatherController : Controller
    {
        private readonly IStateWeatherService StateWeatherService;

        public StateWeatherController(IStateWeatherService StateWeatherService)
        {
            this.StateWeatherService = StateWeatherService;
        }

        // API to Get Weather by Location
        [HttpGet("Weather by State{State}")]
        public async Task<Weather> GetWeatherByState(string State)
        {
            var result = await StateWeatherService.GetWeatherByState(State);

            return result;
        }

    }
}