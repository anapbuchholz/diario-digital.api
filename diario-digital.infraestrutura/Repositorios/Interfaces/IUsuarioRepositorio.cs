using diario_digital.infraestrutura.ModelosBD;
using System.Threading.Tasks;

namespace diario_digital.infraestrutura.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<UsuarioBd> ObterUsuario(int id);
    }
}
