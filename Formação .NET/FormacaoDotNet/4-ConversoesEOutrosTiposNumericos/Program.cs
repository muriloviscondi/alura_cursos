using System;

namespace _4_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 4");

            double salario;
            salario = 1200.50;

            // O int é um tipo de variável que suporta até 32 bits
            int salarioInteiro = (int)salario;

            // O long é um tipo de variável que suporta até 64 bits
            long idade = 13000000000;
            Console.WriteLine(idade);

            // O short é um tipo de variável que suporta até 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine("Execução finalizada. Tecle enter para sair. . .");
            Console.ReadLine();
        }
    }
}
