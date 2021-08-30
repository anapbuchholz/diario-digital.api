using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diario_digital.servicos.Entidades
{
    public class PostagemEntidade
    {
        public Guid Id { get; }

        public DateTime DataDaPostagem { get; set; }

        public string Conteudo { get; set; }

        public int Curtidas { get; set; }

        public List<ComentarioEntidade> Comentarios { get; set; }

        public Guid UsuarioId { get; }
    }
}
