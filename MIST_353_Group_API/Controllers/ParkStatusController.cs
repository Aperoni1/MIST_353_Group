using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Repositories;
using System.Threading.Tasks;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkStatusController : ControllerBase
    {
        private readonly IParkStatusService _parkStatusService;

        public ParkStatusController(IParkStatusService parkStatusService)
        {
            _parkStatusService = parkStatusService;
        }

        // GET: api/parkstatus/{parkName}
        [HttpGet("{parkName}")]
        public async Task<IActionResult> GetParkStatus(string parkName)
        {
            var status = await _parkStatusService.GetParkStatus(parkName);
            return Ok(status);
        }
    }
}
