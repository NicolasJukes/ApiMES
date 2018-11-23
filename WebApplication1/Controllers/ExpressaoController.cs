using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;
using WebApplication1.Servicos;

namespace WebApplication1.Controllers
{
    [RoutePrefix("api/expressoes")]
    public class ExpressaoController : ApiController
    {
        // POST: Adição
        [HttpPost]
        [Route("calcularEpressao")]
        public IHttpActionResult Calculo([FromBody] ParametroApiExpressao parametro)
        {
            VerificarExpressao verificarExpressao = new VerificarExpressao();
            verificarExpressao.CalcularExpressao(parametro);
            return ;
        }

    }


}