using Microsoft.AspNetCore.Mvc;
using WebWhatsAppClone.DataBase;

namespace WebWhatsAppClone.Controllers
{
    [ApiController]
    [Route("api/v1/continents")]
    public class ContinentController
    {
        private readonly DataContext _data_context;
        public ContinentController(DataContext data_context)
        {
            _data_context = data_context;
        }
        [HttpPost("store")]
        public async Task<IActionResult> Store([FromForm] )
        {

        }
    }
}
