using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if(usuarioAutenticado)
            {
                System.Console.WriteLine("Bem-vindo ao Sistema!");
                return true;
            } 
            else
            {
                System.Console.WriteLine("Senha Incorreta");
                return false;
            }
        }
    }
}
