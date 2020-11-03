using ByteBank.Funcionarios;
using ByteBank.Sistemas;
using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            // CalcularBonificacao();

            UsarSistema();

            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";
            roberta.Senha = "123";

            GerenteDeConta camila = new GerenteDeConta("326+985+628-89");
            camila.Nome = "Camila";
            camila.Senha = "abx";

            sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(camila, "abx");
        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Design pedro = new Design("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("159.753.398-04");
            roberta.Nome = "Roberta";

            Auxiliar igor = new Auxiliar("981.198.778-53");
            igor.Nome = "Igo";

            GerenteDeConta camila = new GerenteDeConta("326+985+628-89");
            camila.Nome = "Camila";

            Desenvolvedor murilo = new Desenvolvedor("456.123.789 - 20");
            murilo.Nome = "Murilo";

            gerenciadorBonificacao.Registrar(murilo);
            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine($"Total de bonificações do mês: ${gerenciadorBonificacao.GetTotalBonificacao():C}");
        }
    }
}
