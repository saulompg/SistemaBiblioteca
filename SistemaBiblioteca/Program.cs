using SistemaBiblioteca;
using SistemaBiblioteca.command;
using SistemaBiblioteca.entidade;
using SistemaBiblioteca.factory;

Repository repo = Repository.Instancia;
CommandRegistry registry = new CommandRegistry();
CommandInvoker invoker = new CommandInvoker(registry);
ConsoleUI consoleUI = new ConsoleUI(invoker);

// preencher fabrica de comandos
registry.AdicionarComando("emp", new EmprestarCommandFactory());
registry.AdicionarComando("dev", new DevolverCommandFactory());
registry.AdicionarComando("res", new ReservarCommandFactory());
registry.AdicionarComando("obs", new ObservarCommandFactory());
registry.AdicionarComando("ntf", new ConsultarNotificacaoCommandFactory());
registry.AdicionarComando("usu", new ConsultarUsuarioCommandFactory());
registry.AdicionarComando("liv", new ConsultarLivroCommandFactory());
registry.AdicionarComando("sai", new SairCommandFactory(() => consoleUI.Encerrar()));

// preencher repositório usuário
repo.AdicionarUsuario(new AlunoGraduacao("123", "João da Silva"));
repo.AdicionarUsuario(new AlunoPosGraduacao("456", "Luiz Fernando Rodrigues"));
repo.AdicionarUsuario(new AlunoGraduacao("789", "Pedro Paulo"));
repo.AdicionarUsuario(new Professor("100", "Carlos Lucena"));

// preencher repositório livro
repo.AdicionarLivro(new Livro("100", "Engenharia de Software", "Addison Wesley", ["Ian Sommervile"], "6a", 2000));
repo.AdicionarLivro(new Livro("101", "UML - Guia do Usuário", "Campus", ["Grady Booch", "James Rumbaugh", "Ivar Jacobson"], "7a", 2000));
repo.AdicionarLivro(new Livro("200", "Code Complete", "Microsoft Press",["Steve McConnell"], "2a", 2014));
repo.AdicionarLivro(new Livro("201", "Agile Software Development, Principles, Patterns and Practices", "Microsoft Press", ["Robert Martin"], "1a", 2002));
repo.AdicionarLivro(new Livro("300", "Refactoring: Improving the Design of Existing Code", "Addison Wesley Professional",["Martin Fowler"], "1a", 1999));
repo.AdicionarLivro(new Livro("301", "Software Metrics: A Rigorous and Practical Approach", "CRC Press", ["Norman Fenton", "James Bieman"], "3a", 2014));
repo.AdicionarLivro(new Livro("400", "Design Patterns: Element of Reusable Object-Oriented Software", "Addison Wesley Professional", ["Erich Gamma", "Richard Helm", "Ralph Johnson", "John Vlissides"], "1a", 1994));
repo.AdicionarLivro(new Livro("401", "UML Distilled: A Brief Guide to the Standard Object Modeling Language", "Addison Wesley Professional", ["Martin Fowler"], "3a", 2003));

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
consoleUI.Iniciar();