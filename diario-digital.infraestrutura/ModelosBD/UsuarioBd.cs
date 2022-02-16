using System;

namespace diario_digital.infraestrutura.ModelosBD
{
    public class UsuarioBd
    {
        public int Id { get; set; }

        public DateTime DataDeNascimento { get; set; }

        public string Nome { get; set; }

        public string Sexo { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string FraseDeStatus { get; set; }

        public string FotoDePerfil { get; set; }
    }
}
