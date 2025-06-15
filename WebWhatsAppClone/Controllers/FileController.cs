using Microsoft.AspNetCore.Mvc;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/files")]
    public class FileController : ControllerBase
    {
        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            return Ok();
        }
        [HttpPost("upload-multiple")]
        public async Task<IActionResult> UploadMultiple(IFormFileCollection files)
        {
            return Ok();
        }
    }
}
