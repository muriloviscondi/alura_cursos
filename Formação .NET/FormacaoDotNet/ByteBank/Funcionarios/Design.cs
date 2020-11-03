using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Design : Funcionario
    {
        public Design(string cpf) : base(3000, cpf)
        {
            Console.WriteLine("criando Design");
        }

        public override void AumentarSalario()
        {
            // Salario = Salario + (Salario * 0.1);
            // Salario = Salario * 1.1;
            Salario *= 1.11;
        }

        public override double GetBonificacao()
        {
            return Salario *= 0.17;
        }

    }
}
