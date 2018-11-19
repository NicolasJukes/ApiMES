using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class ExpressaoController : Controller
    {
        // GET: Adição
       [HttpGet]
        public double Adicao(double valor1, double valor2)
       {
            var Adicao = new Adicao.Adicao();
            return Adicao.Calcular(valor1, valor2);
        }

        // GET: Subtração
        [HttpGet]
        public double Subtrair(double valor1, double valor2)
        {
            var calcularSubtracao = new Subtracao.Subtracao();
            return calcularSubtracao.Calcular(valor1, valor2);
        }
    }

    
}