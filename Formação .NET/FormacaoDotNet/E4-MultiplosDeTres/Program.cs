using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_MultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Múltiplos de 3");

            for(int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write($"{i} ");
                }
            }

            Console.ReadLine();
        }
    }
}
