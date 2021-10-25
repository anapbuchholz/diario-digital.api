using diario_digital.servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Threading.Tasks;

namespace diario_digital.api.Controllers
{
    [ApiController]
    [Route("usuarios")]
    public class UsuarioController : ControllerBase
    {
        public UsuarioServico UsuarioServico { get; set; }

        public UsuarioController()
        {
            UsuarioServico = new UsuarioServico();
        }

        [Route("{Id}")]
        public async Task<IActionResult> ObterUsuario([FromRoute] int id)
        {
            var usuario = await UsuarioServico.ObterUsuario(id);
            if (usuario == null)
                return NotFound(new ResponseModel { StatusCode = HttpStatusCode.NotFound });               
            
            return Ok(new ResponseModel { StatusCode = HttpStatusCode.OK, Corpo = usuario });
        }
    }
}
