using System.Net;

namespace diario_digital.api
{
    public class ResponseModel
    {
        public HttpStatusCode StatusCode { get; set; }
        public string Mensagem { get; set; }
        public object Corpo { get; set; }
    }
}
