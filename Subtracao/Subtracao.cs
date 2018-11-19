using Subtracao.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtracao
{
    public class Subtracao : ISubtracao
    {
        public double Calcular(double valor1, double valor2)
        {
            return valor1 - valor2;
        }
    }
}
