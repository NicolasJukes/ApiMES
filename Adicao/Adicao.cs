using Adicao.Intarface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adicao
{
    public class Adicao : IAdicao
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
