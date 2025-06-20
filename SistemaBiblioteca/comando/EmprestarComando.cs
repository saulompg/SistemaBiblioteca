namespace ProjetoBiblioteca.comando;

public class EmprestarComando : IComando
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public EmprestarComando(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Executar()
    {
        Console.WriteLine("Emprestando livro");
    }
}