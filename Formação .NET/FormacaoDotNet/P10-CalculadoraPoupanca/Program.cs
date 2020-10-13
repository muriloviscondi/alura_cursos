using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_CalculadoraPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - Calcula poupança");

            double valorInvestido = 1000;
            int count = 0;

            while (count < 12)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.36 / 100);
                count++;

                Console.WriteLine($"Após {count} mês você terá R$ {valorInvestido}");
            }

            valorInvestido = 1000;
            count = 0;

            do
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.36 / 100);
                count++;

                Console.WriteLine($"Após {count} mês você terá R$ {valorInvestido}");
            } while (count < 12);


            Console.ReadLine();
        }
    }
}
