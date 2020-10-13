using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E5_Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fatorial");
            int num = 3;

            var fatorial = new Fatorial();

            Console.WriteLine($"O fatorial de {num} é ({num-1}!) * {num} = {fatorial.CalculateFatorial(num)}");

            Console.ReadLine();
        }
    }
}
