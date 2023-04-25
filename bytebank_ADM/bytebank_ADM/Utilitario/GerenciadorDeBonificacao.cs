using bytebank_ADM.Funcionarios;

namespace bytebank_ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacoes { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacoes += funcionario.GetBonificacao();
        }
    }
}