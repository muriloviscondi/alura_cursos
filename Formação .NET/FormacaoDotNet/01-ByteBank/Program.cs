using System;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGabriela =  new ContaCorrente();

            contaGabriela.titular = "Gabriela";
            contaGabriela.agencia = 826;
            contaGabriela.numero = 826549;
            contaGabriela.saldo = 100;

            Console.WriteLine(contaGabriela.titular);
            Console.WriteLine("Agência: " + contaGabriela.agencia);
            Console.WriteLine("Número: "+ contaGabriela.numero);
            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            contaGabriela.saldo += 200;

            Console.WriteLine("Saldo: " + contaGabriela.saldo);

            Console.ReadLine();
        }
    }
}
