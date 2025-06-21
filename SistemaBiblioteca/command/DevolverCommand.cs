namespace ProjetoBiblioteca.command;

public class DevolverCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public DevolverCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        output = "Devolvendo livros";
    }
}