using ProjetoBiblioteca.comando;

bool executando = true;

SistemaBiblioteca sistemaBiblioteca = new SistemaBiblioteca();

sistemaBiblioteca.Adicionar("emp", args => new EmprestarComando(args[1], args[2]));
sistemaBiblioteca.Adicionar("dev", args => new DevolverComando(args[1], args[2]));
sistemaBiblioteca.Adicionar("res", args => new ReservarComando(args[1], args[2]));
sistemaBiblioteca.Adicionar("obs", args => new ObservarComando(args[1], args[2]));
sistemaBiblioteca.Adicionar("ntf", args => new ConsultarNotificacaoComando(args[1]));
sistemaBiblioteca.Adicionar("usu", args => new ConsultarUsuarioComando(args[1]));
sistemaBiblioteca.Adicionar("liv", args => new ConsultarLivroComando(args[1]));
sistemaBiblioteca.Adicionar("sai", _ => new SairComando(() => executando = false));

while (executando)
{
    Console.WriteLine("Digite um comando:");
    Console.Write("> ");
    var input = Console.ReadLine()?.Trim();
    if (string.IsNullOrWhiteSpace(input))
        continue;
    try
    {
        sistemaBiblioteca.ExecutarComando(input);
    }
    catch (Exception e)
    {
        Console.WriteLine("Erro | " + e.Message);
    }
}

Console.WriteLine("Programa finalizado.");
