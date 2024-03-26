using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Conta;
using Spotify.Application.Streaming;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlanoController : ControllerBase
    {
        private PlanoService _planoService;

        public PlanoController(PlanoService planoService)
        {
            _planoService = planoService;
        }

        [HttpGet]
        public IActionResult GetPlanos()
        {
            var result = this._planoService.Obter();

            return Ok(result);
        }
    }
}
