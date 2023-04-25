using bytebank_ADM.Parceria;

namespace bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao ByteBank! ;-)");
                return true;
            }
            else
            {
                Console.WriteLine("Algo deu errado, tente novamente! ;-(");
                return false;
            }
        }
    }
}
