namespace ProjetoBiblioteca.command;

public class ObservarCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public ObservarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        output = "Cadastrado como observador";
    }
}