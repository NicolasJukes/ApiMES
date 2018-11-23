using Adicao.Models;
using System.Web.Http;

namespace Adicao.Controllers
{
    [RoutePrefix("api/adicao")]
    public class AdicaoController : ApiController
    {
        public AdicaoController(){}

        [HttpPost]
        [Route("adicionar")]
        public double Adicionar(double valor1, double valor2)
        {
            Adicionar adicionar = new Adicionar();
            return adicionar.Calcule(valor1, valor2);
        }
    }
}