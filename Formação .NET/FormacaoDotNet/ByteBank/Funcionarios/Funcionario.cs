namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        // 0 - funcionário padrão
        // 1 - diretor
        // 2 - design
        // 3 - Gerente de conta corrente
        // 3 - Coordenador
        // N - ...
        private int _tipo;

        public Funcionario(int tipo)
        {
            _tipo = tipo;
        }


        public string Nome { get; set; }
        
        public string CPF { get; set; }
        
        public double Salario { get; set; }


        public double GetBonificacao()
        {
            return Salario * 0.10;
        }
    }
}
