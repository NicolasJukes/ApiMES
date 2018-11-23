using Contrato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adicao.Models
{
    public class Adicionar : ICalcular
    {
        public double Calcule(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}