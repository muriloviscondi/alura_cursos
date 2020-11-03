using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalFuncionarios++;
        }

        public static int TotalFuncionarios { get; private set; }

        public string Nome { get; set; }
        
        public string CPF { get; private set; }
        
        public double Salario { get; protected set; }

        public abstract void AumentarSalario();
        
        public abstract double GetBonificacao();
       
    }
}
