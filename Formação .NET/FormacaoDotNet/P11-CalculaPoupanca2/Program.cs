using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_CalculaPoupanca2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 11 - Calcula poupança");

            double valorInvestido = 1000;

            for (int i = 0; i < 12; i++)
            {
                valorInvestido = valorInvestido * 1.0036;

                Console.WriteLine($"Após {i + 1} mês você terá {valorInvestido:C}");
            }

            Console.ReadLine();
        }
    }
}
