namespace ProjetoBiblioteca.comando;

public class ObservarComando : IComando
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public ObservarComando(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Executar()
    {
        Console.WriteLine("Cadastrado como observador");
    }
}