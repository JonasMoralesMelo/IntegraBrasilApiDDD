using System.Net;
using artigotech_integra_brasilapi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace artigotech_integra_brasilapi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class DDDController : ControllerBase
    {
        public readonly IDDDService _dddService;

        public DDDController(IDDDService dddService)
        {
            _dddService = dddService;
        }

        [HttpGet("busca/{ddd}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> BuscarEndereco([FromRoute] int ddd) 
        {
            var response = await _dddService.BuscarDDD(ddd);

            if(response.CodigoHttp == HttpStatusCode.OK) 
            {
                return Ok(response.DadosRetorno);
            }
            else 
            {
                return StatusCode((int)response.CodigoHttp, response.ErroRetorno);
            }
        }
    }
}