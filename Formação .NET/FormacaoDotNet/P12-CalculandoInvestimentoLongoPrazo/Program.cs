using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_CalculandoInvestimentoLongoPrazo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 12");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;
            int tempoInvestimento = 0;

            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 12; j++)
                {
                    valorInvestido *= fatorRendimento;
                }

                fatorRendimento += 0.0010;
                tempoInvestimento++;
            }

            Console.WriteLine($"O tempo de investimento foi de {tempoInvestimento} anos");
            Console.WriteLine($"Ao término do investimento, você terá {valorInvestido:C}");

            Console.ReadLine();
        }
    }
}
