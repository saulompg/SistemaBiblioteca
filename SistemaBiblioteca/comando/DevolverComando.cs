namespace ProjetoBiblioteca.comando;

public class DevolverComando : IComando
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public DevolverComando(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Executar()
    {
        Console.WriteLine("Devolvendo livros");
    }
}