namespace ProjetoBiblioteca.command;

public class ConsultarNotificacaoCommand : ICommand
{
    private string _codigoUsuario;
    public ConsultarNotificacaoCommand(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    public void Execute(out string output)
    {
        output = "Notificações do usuário";
    }
}