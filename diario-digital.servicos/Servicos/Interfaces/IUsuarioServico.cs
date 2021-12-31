using diario_digital.servicos.Entidades;
using System.Threading.Tasks;

namespace diario_digital.servicos.Servicos.Interfaces
{
    public interface IUsuarioServico
    {
        Task<UsuarioEntidade> ObterUsuario(int id);
    }
}
