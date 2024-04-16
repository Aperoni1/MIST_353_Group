using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Entities;
using MIST_353_Group_API.Repositories;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireWarningController : ControllerBase
    {
        private readonly IFireWarningRepository _fireWarningRepository;

        public FireWarningController(IFireWarningRepository fireWarningRepository)
        {
            _fireWarningRepository = fireWarningRepository;
        }

        // POST: api/firewarning
        [HttpPost]
        public IActionResult CreateFireWarning([FromBody] FireWarning fireWarning)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _fireWarningRepository.CreateFireWarning(fireWarning);

            // Optionally return a response with the created resource
            return CreatedAtAction(nameof(GetFireWarning), new { id = fireWarning.FireWarningID }, fireWarning);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFireWarning(int id)
        {
            var fireWarning = await _fireWarningRepository.GetFireWarningById(id);

            if (fireWarning == null)
            {
                return NotFound();
            }

            return Ok(fireWarning);
        }
    }
}
