using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E2_TransformandoWhileEmFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            while (contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            // Transformando em FOR
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}
