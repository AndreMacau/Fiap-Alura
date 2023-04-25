using bytebank_ADM.Funcionarios;
using bytebank_ADM.Parceria;
using bytebank_ADM.SistemaInterno;
using bytebank_ADM.Utilitario;

#region
//Funcionario pedro = new Funcionario("123456789", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine($"Nome: {pedro.Nome}");
//Console.WriteLine($"CPF: {pedro.Cpf}");
//Console.WriteLine($"Bonificação do mês: {pedro.GetBonificacao()}");

//Diretor roberta= new Diretor("987654321");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine($"Nome: {roberta.Nome}");
//Console.WriteLine($"CPF: {roberta.Cpf}");
//Console.WriteLine($"Bonificação do mês: {roberta.GetBonificacao()}");

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine($"Total de Bonificações: {gerenciador.TotalDeBonificacoes}");
//Console.WriteLine($"Total de Funcionários: {Funcionario.TotalDeFuncionarios}");

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine($"Novo salário do Pedro: {pedro.Salario}");
//Console.WriteLine($"Novo salário do Roberta: {roberta.Salario}");
#endregion
#region
CalcularBonificacao();
UsarSistema();
void CalcularBonificacao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
    
    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Sousa";

    Diretor paula = new Diretor("456987");
    ulisses.Nome = "Paula Sousa";

    Auxiliar igor = new Auxiliar("369852");
    igor.Nome = "Igor Diaz";

    GerenteDeContas camila = new GerenteDeContas("564197");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine($"Total de bonificações: {gerenciador.TotalDeBonificacoes}");
}
#endregion
void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("123559");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("556985");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    ////Não possui Senha
    //Auxiliar henrique = new Auxiliar("7264545");
    //henrique.Nome = "Henrique Sousa";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "423");
    sistema.Logar(caio, "999");
}