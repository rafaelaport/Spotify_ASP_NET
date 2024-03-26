using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Spotify.Application.Conta;
using Spotify.Application.Streaming;

namespace Spotify.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartaoController : ControllerBase
    {
        private CartaoService _cartaoService;

        public CartaoController(CartaoService cartaoService)
        {
            _cartaoService = cartaoService;
        }

        [HttpGet]
        public IActionResult GetPlanos()
        {
            var result = this._cartaoService.Obter();

            return Ok(result);
        }
    }
}
