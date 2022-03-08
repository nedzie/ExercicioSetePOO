using System;

namespace ExercicioSete.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vendedor marcos = new Vendedor();
            Console.Write("Informe o salário base do vendedor: \n> R$");
            marcos.salarioBase = double.Parse(Console.ReadLine());
            Console.Write("Informe o total de vendas dele: \n> R$");
            marcos.totalDeVendas = double.Parse(Console.ReadLine());
            Console.Write("Informe o percentual de comissão: \n> ");
            marcos.percentualDeComissao = double.Parse(Console.ReadLine());

            marcos.salarioTotal = marcos.CalcularSalarioTotal(marcos.salarioBase, marcos.totalDeVendas, marcos.percentualDeComissao);

            Console.WriteLine("O salário total do vendedor é de: R$" + marcos.salarioTotal + ".");
        }
    }
}