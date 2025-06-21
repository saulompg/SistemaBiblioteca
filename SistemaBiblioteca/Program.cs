using ProjetoBiblioteca;
using ProjetoBiblioteca.command;
using ProjetoBiblioteca.entidade;
using ProjetoBiblioteca.factory;

bool executando = true;

CommandRegistry commandRegistry = new CommandRegistry();

// preencher fabrica de comandos
commandRegistry.AdicionarComando("emp", new EmprestarCommandFactory());
commandRegistry.AdicionarComando("dev", new DevolverCommandFactory());
commandRegistry.AdicionarComando("res", new ReservarCommandFactory());
commandRegistry.AdicionarComando("obs", new ObservarCommandFactory());
commandRegistry.AdicionarComando("ntf", new ConsultarNotificacaoCommandFactory());
commandRegistry.AdicionarComando("usu", new ConsultarUsuarioCommandFactory());
commandRegistry.AdicionarComando("liv", new ConsultarLivroCommandFactory());
commandRegistry.AdicionarComando("sai", new SairCommandFactory(() => executando = false));

Repository repo = Repository.Instancia;
// preencher repositório usuário
repo.AdicionarUsuario(new AlunoGraduacao("123", "João da Silva"));
repo.AdicionarUsuario(new AlunoPosGraduacao("456", "Luiz Fernando Rodrigues"));
repo.AdicionarUsuario(new AlunoGraduacao("789", "Pedro Paulo"));
repo.AdicionarUsuario(new Professor("100", "Carlos Lucena"));
// preencher repositório livro
repo.AdicionarLivro(new Livro("100", "Engenharia de Software", "Addison Wesley"));
repo.AdicionarLivro(new Livro("101", "UML - Guia do Usuário", "Campus"));
repo.AdicionarLivro(new Livro("200", "Code Complete", "Microsoft Press"));
repo.AdicionarLivro(new Livro("201", "Agile Software Development, Principles, Patterns and Practices", "Microsoft Press"));
repo.AdicionarLivro(new Livro("300", "Refactoring: Improving the Design of Existing Code", "Addison Wesley Professional"));
repo.AdicionarLivro(new Livro("301", "Software Metrics: A Rigorous and Practical Approach", "CRC Press"));
repo.AdicionarLivro(new Livro("400", "Design Patterns: Element of Reusable Object-Oriented Software", "Addison Wesley Professional"));
repo.AdicionarLivro(new Livro("401", "UML Distilled: A Brief Guide to the Standard Object Modeling Language", "Addison Wesley Professional"));
// adicionando exemplares
repo.BuscarLivroPorCodigo("100").AdicionarExemplar("01");
repo.BuscarLivroPorCodigo("100").AdicionarExemplar("02");
repo.BuscarLivroPorCodigo("101").AdicionarExemplar("03");
repo.BuscarLivroPorCodigo("200").AdicionarExemplar("04");
repo.BuscarLivroPorCodigo("201").AdicionarExemplar("05");
repo.BuscarLivroPorCodigo("300").AdicionarExemplar("06");
repo.BuscarLivroPorCodigo("300").AdicionarExemplar("07");
repo.BuscarLivroPorCodigo("400").AdicionarExemplar("08");
repo.BuscarLivroPorCodigo("400").AdicionarExemplar("09");

// execução principal
CommandInvoker invoker = new CommandInvoker(commandRegistry);

Console.WriteLine("Sistema de Biblioteca Acadêmica Iniciado");
while (executando)
{
    Console.WriteLine("Digite um comando:");
    Console.Write("> ");
    var input = Console.ReadLine()?.Trim();
    if (string.IsNullOrWhiteSpace(input))
        continue;
    try
    {
        invoker.ExecutarComando(input, out string output);
        Console.WriteLine(output);
    }
    catch (Exception e)
    {
        Console.WriteLine("Erro | " + e.Message);
    }
}

Console.WriteLine("Programa finalizado.");