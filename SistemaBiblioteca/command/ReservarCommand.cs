namespace ProjetoBiblioteca.command;

public class ReservarCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public ReservarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        output = "Livro reservado";
    }
}