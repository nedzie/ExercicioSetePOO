using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioSete.ConsoleApp
{
    internal class Vendedor
    {
        public double salarioBase;
        public double totalDeVendas;
        public double percentualDeComissao;
        public double salarioTotal;

        public double CalcularSalarioTotal(double salarioBase, double totalDeVendas, double percentualDeComissao)
        {
            salarioTotal = salarioBase + (totalDeVendas * (percentualDeComissao / 100));
            return salarioTotal;
        }
    }
}