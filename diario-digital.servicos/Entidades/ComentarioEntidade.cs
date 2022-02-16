using System;

namespace diario_digital.servicos.Entidades
{
    public class ComentarioEntidade
    {
        public Guid Id { get; }

        public DateTime DataDePostagem { get; set; }

        public string Conteudo { get; set; }

        public int QuantidadeDeCurtidas { get; set; }

        public Guid PostagemId { get; }
    }
}
