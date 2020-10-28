using ByteBank.Funcionarios;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario carlos = new Funcionario();
            carlos.Nome = "Carlos";
            carlos.CPF = "000.000.000.-00";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();
            roberta.Nome = "Roberta";
            roberta.CPF = "000.000.000.-01";
            roberta.Salario = 5000;

            Funcionario robertaTeste = roberta;

            Console.WriteLine("Bonificação de uma referencia de diretor: " + roberta.Salario);
            Console.WriteLine("Bonificação de uma referencia de funcionario: " + robertaTeste.Salario);
            
            gerenciador.Registrar(roberta);

            Console.WriteLine(carlos.Nome);
            Console.WriteLine(carlos.GetBonificacao());
           
            Console.WriteLine(roberta.Nome);
            Console.WriteLine(roberta.GetBonificacao());

            Console.WriteLine($"Total de bonificações: {gerenciador.GetTotalBonificacao()}");

            Console.ReadLine();
        }
    }
}
