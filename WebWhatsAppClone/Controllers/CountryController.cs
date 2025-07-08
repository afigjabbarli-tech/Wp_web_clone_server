using Microsoft.AspNetCore.Mvc;
using WebWhatsAppClone.DataBase;
using WebWhatsAppClone.DataBase.Entities;
using WebWhatsAppClone.DTOs.Api;
using WebWhatsAppClone.DTOs.Country;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/countries")]
    public class CountryController : ControllerBase
    {
        private readonly DataContext _data_context;
        public CountryController(DataContext data_context)
        {
            _data_context = data_context;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] CountryCreateDTO DTO)
        {
            var request_start_time = DateTimeOffset.UtcNow;
            DateTimeOffset request_end_time;
            long duration;

            try
            {

            }
            catch (Exception)
            {
                request_end_time = DateTimeOffset.UtcNow;
                duration = (long)(request_end_time - request_start_time).TotalMilliseconds;
                var internal_server_error_response = new ApiResponse<TemporaryEntity, DateTimeOffset>()
                    .InternalServerErrorResponse(request_time: request_start_time, response_time: request_end_time, duration_ms: duration);
            }
            return Ok();
        }
    }
}
