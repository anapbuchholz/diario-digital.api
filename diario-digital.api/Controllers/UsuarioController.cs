using diario_digital.servicos.Servicos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<IActionResult> ObterUsuario([FromRoute] Guid id)
        {
            var usuario = await UsuarioServico.ObterUsuario(id);
            if (usuario == null)
                NotFound();

            return Ok(usuario);
        }
    }
}
