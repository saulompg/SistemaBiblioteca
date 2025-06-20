namespace ProjetoBiblioteca.comando;

public class ConsultarNotificacaoComando : IComando
{
    private string _codigoUsuario;
    public ConsultarNotificacaoComando(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    public void Executar()
    {
        Console.WriteLine("Notificações do usuário");
    }
}