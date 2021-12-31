using diario_digital.infraestrutura.ModelosBD;
using diario_digital.infraestrutura.Repositorios.Interfaces;
using System;
using System.Threading.Tasks;

namespace diario_digital.infraestrutura.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public async Task<UsuarioBd> ObterUsuario(int id)
        {
            var usuario = new UsuarioBd
            {
                Id = 1,
                DataDeNascimento = new DateTime(2021, 09, 01),
                Senha = "1234",
                Sexo = "FEMININO",
                Email = "teste@gmail.com",
                FraseDeStatus = "9vinh0",
                Nome = "Antonio Nunes"
            };

            if (id != usuario.Id)
                return null;

            return usuario;
        }
    }
}
