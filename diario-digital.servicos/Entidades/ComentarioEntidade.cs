using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
