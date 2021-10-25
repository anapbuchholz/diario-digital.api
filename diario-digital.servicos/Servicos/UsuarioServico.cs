using diario_digital.infraestrutura.Repositorios;
using diario_digital.servicos.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace diario_digital.servicos.Servicos
{
    public class UsuarioServico
    {
        public UsuarioRepositorio UsuarioRepositorio { get; set; }

        public UsuarioServico()
        {
            UsuarioRepositorio = new UsuarioRepositorio();
        }

        public async Task<UsuarioEntidade> ObterUsuario(Guid id)
        {
            var usuario = await UsuarioRepositorio.ObterUsuario(id);
            var usuarioEntidade = new UsuarioEntidade(usuario);
            return usuarioEntidade;
        }
    }
}
