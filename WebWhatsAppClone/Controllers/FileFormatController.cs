using Microsoft.AspNetCore.Mvc;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/file_formats")]
    public class FileFormatController : ControllerBase
    {
        public FileFormatController()
        {
            
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store()
        {
            return Ok();
        }
    }
}
