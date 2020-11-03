using ByteBank.Sistemas;
using System;

namespace ByteBank.Funcionarios
{
    public class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(4000, cpf)
        {
            Console.WriteLine("criando Gerente de Conta");
        }

        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.05;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.25;
        }

    }
}
