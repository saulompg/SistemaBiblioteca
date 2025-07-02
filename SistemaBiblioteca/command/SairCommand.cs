namespace SistemaBiblioteca.command;

public class SairCommand : ICommand
{
    private readonly Action _encerrarSistema;

    public SairCommand(Action encerrarSistema)
    {
        _encerrarSistema = encerrarSistema;
    }
    public void Execute(out string output)
    {
        output = "Encerrando o Programa...";
        _encerrarSistema();
    }
}