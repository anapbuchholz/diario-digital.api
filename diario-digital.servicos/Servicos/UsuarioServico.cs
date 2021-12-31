using diario_digital.infraestrutura.Repositorios.Interfaces;
using diario_digital.servicos.Entidades;
using diario_digital.servicos.Servicos.Interfaces;
using System.Threading.Tasks;

namespace diario_digital.servicos.Servicos
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public async Task<UsuarioEntidade> ObterUsuario(int id)
        {
            var usuario = await _usuarioRepositorio.ObterUsuario(id);

            if (usuario == null)
                return null;

            var usuarioEntidade = new UsuarioEntidade(usuario);
            return usuarioEntidade;
        }
    }
}
