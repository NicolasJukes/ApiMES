using Contrato;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.Servicos
{
    public class VerificarExpressao
    {
        public double CalcularExpressao(ParametroApiExpressao parametro)
        {
            var operador = "";
            if (parametro.Expressao.Contains(Operador.ADICAO)) { operador = Operador.ADICAO; }
            else if (parametro.Expressao.Contains(Operador.SUBTRACAO)) { operador = Operador.SUBTRACAO; }

            if (operador.Contains('+'))
            {
                var resposta = SendRequest(parametro, operador);
                return Convert.ToDouble(resposta.Content.ReadAsStringAsync().Result);
            }
            else
            {
                var resposta = SendRequest(parametro, operador);
                return Convert.ToDouble(resposta.Content.ReadAsStringAsync().Result);
            }

        }
        public HttpResponseMessage SendRequest(ParametroApiExpressao parametro, string operador)
        {
            HttpClient client = new HttpClient();
            var myContent = JsonConvert.SerializeObject(MontaExpressao(parametro, operador));
            var stringContent = new StringContent(myContent);
            client.BaseAddress = new Uri("http://localhost:50495");
            var url = operador == "+" ? "/api/adicao/adicionar" : "/api/subtracao/subtrair";

            return client.PostAsync(url, stringContent).Result;
        }

        public object MontaExpressao(ParametroApiExpressao parametro, string operador)
        {
            int indexOperador = parametro.Expressao.IndexOf(operador);
            int indexOperadorCalculado = indexOperador = +1;
            var valor1 = parametro.Expressao.Substring(0, indexOperador);
            var valor2 = parametro.Expressao.Substring(indexOperadorCalculado, 
                (parametro.Expressao.Length - indexOperadorCalculado));
            var valores = new { valor1 = valor1, valor2 = valor2 };

            return valores;
        }
    }
}