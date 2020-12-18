using Microsoft.AspNetCore.Mvc;
using PolymorphicAPI.Models;

namespace PolymorphicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(200)]
        public IActionResult Post([FromBody]EventCommand command)
        {
            return Ok(command);
        }
    }
}
