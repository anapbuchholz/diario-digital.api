using diario_digital.infraestrutura.ModelosBD;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace diario_digital.infraestrutura.Repositorios
{
    public class UsuarioRepositorio
    {
        public async Task<UsuarioBd> ObterUsuario(Guid id)
        {
            var usuario = new UsuarioBd
            {
                Id = new Guid("1234-1234-1234-1234"),
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
