using Microsoft.AspNetCore.Mvc;
using MIST_353_Group_API.Entities;

namespace MIST_353_Group_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FireWarningController : ControllerBase
    {
        private readonly List<FireWarning> _fireWarnings; 

        public FireWarningController()
        {
            // Initialize in-memory storage
            _fireWarnings = new List<FireWarning>();
        }

        // POST: api/firewarning
        [HttpPost]
        public IActionResult CreateFireWarning([FromBody] FireWarning fireWarning)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

          
            fireWarning.FireWarningID = _fireWarnings.Count + 1;
            _fireWarnings.Add(fireWarning);

            return CreatedAtAction(nameof(GetFireWarning), new { id = fireWarning.FireWarningID }, fireWarning);
        }

        // GET: api/firewarning/{id}
        [HttpGet("{id}")]
        public IActionResult GetFireWarning(int id)
        {
            var fireWarning = _fireWarnings.Find(fw => fw.FireWarningID == id);

            if (fireWarning == null)
            {
                return NotFound();
            }

            return Ok(fireWarning);
        }
    }
}
