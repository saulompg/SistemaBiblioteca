namespace ProjetoBiblioteca.command;

public class SairCommand : ICommand
{
    private readonly Action _sair;

    public SairCommand(Action sair)
    {
        _sair = sair;
    }
    public void Execute(out string output)
    {
        output = "Encerrando o Programa...";
        _sair.Invoke();
    }
}