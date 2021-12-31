using diario_digital.servicos.Servicos;
using diario_digital.servicos.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace diario_digital.api.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        public readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ObterUsuario([FromRoute] int id)
        {
            var usuario = await _usuarioServico.ObterUsuario(id);
            if (usuario == null)
                return NotFound(new ResponseModel { StatusCode = HttpStatusCode.NotFound });               
            
            return Ok(new ResponseModel { StatusCode = HttpStatusCode.OK, Corpo = usuario });
        }
    }
}
