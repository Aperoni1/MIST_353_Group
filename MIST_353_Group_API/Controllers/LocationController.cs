using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Entities;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LocationController : Controller
    {
        private readonly IParkLocationService ParkLocationService;

        public LocationController(IParkLocationService ParkLocationService)
        {
            this.ParkLocationService = ParkLocationService;
        }
        [HttpGet("{inputLat}/{inputLon}")]
        public async Task<Location> GetNearestPark(int inputLat, int inputLon)
        {
            var parkResult = await ParkLocationService.GetNearestPark(inputLat, inputLon);
            if (parkResult == null)
            {
                //return NotFound();
            }
            return parkResult;
        }

    }
}
