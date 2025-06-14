using Microsoft.AspNetCore.Mvc;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/social_profiles")]
    public class SocialProfileController : ControllerBase
    {
        [HttpGet("index")]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
        [HttpGet("show/{id}")]
        public async Task<IActionResult> Show()
        {
            return Ok();
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store()
        {
            return Ok();
        }
    }
}
