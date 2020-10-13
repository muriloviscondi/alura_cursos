using System;

namespace AliquotaComIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 3300.0;

            if (salario >= 1900 && salario <= 2800)
            {
                Console.WriteLine("A sua aliquota é de 7.5%");
                Console.WriteLine("Você pode deduzir até R$ 142,00");
            } 
            else if (salario > 2800 && salario <= 3751)
            {
                Console.WriteLine("A sua aliquota é de 15%");
                Console.WriteLine("Você pode deduzir até R$ 350,00");
            }
            else if (salario > 3751 && salario <= 4664)
            {
                Console.WriteLine("A sua aliquota é de 22.5%");
                Console.WriteLine("Você pode deduzir até R$ 636,00");
            }

            Console.ReadLine();
        }
    }
}
