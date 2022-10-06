using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

//program that make a math count about a cellphone call minutes charge
namespace conta
{
    class Program
    {
        static void Main(string[] args)
        {
            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if (minutos > 100)
            {
                conta +=  (minutos - 100) * 2.0;
            }
            Console.WriteLine("Valor a pagar : R$ " + conta.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}