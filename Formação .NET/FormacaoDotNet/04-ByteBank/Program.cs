using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaBruno = new ContaCorrente();

            contaBruno.titular = "Bruno";

            bool resultadoSaque = contaBruno.Sacar(150);

            Console.WriteLine(resultadoSaque);
            Console.WriteLine($"Saldo: {contaBruno.saldo:C}");

            contaBruno.Depositar(500);
            Console.WriteLine($"Saldo: {contaBruno.saldo:C}");

            ContaCorrente contaGabriela = new ContaCorrente();

            contaGabriela.titular = "Gabriela";

            bool resultadoTransferencia = contaBruno.Transferir(100, contaGabriela);
            Console.WriteLine($"Saldo Bruno: {contaBruno.saldo:C}");
            Console.WriteLine($"Saldo Gabriela: {contaGabriela.saldo:C}");
            
            Console.WriteLine($"Resultado transferência: {resultadoTransferencia}");

            contaGabriela.Transferir(200, contaBruno);
            Console.WriteLine($"Saldo Bruno: {contaBruno.saldo:C}");
            Console.WriteLine($"Saldo Gabriela: {contaGabriela.saldo:C}");

            Console.ReadLine();
        }
    }
}
