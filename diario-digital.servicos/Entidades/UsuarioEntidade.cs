using diario_digital.infraestrutura.ModelosBD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diario_digital.servicos.Entidades
{
    public class UsuarioEntidade
    {
        public UsuarioEntidade(UsuarioBd usuarioBd)
        {
            Id = usuarioBd.Id;
            DataDeNascimento = usuarioBd.DataDeNascimento;
            Nome = usuarioBd.Nome;
            Sexo = Enum.Parse<Genero>(usuarioBd.Sexo);
            Senha = usuarioBd.Senha;
            Email = usuarioBd.Email;
            FraseDeStatus = usuarioBd.FraseDeStatus;
            FotoDePerfil = usuarioBd.FotoDePerfil;
        }

        public Guid Id { get; }

        public DateTime DataDeNascimento { get; set; }

        public string Nome { get; set; }

        public Genero Sexo { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string FraseDeStatus { get; set; }

        public string FotoDePerfil { get; set; }

        public List<UsuarioEntidade> Amigos { get; set; }

        public List<PostagemEntidade> Postagem { get; set; }

        public enum Genero
        {
            MASCULINO = 1,
            FEMININO = 2
        };
    }
}
