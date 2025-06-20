namespace ProjetoBiblioteca.comando;

public class ConsultarLivroComando : IComando
{
    private string _codigoLivro;
    public ConsultarLivroComando(string codigoLivro)
    {
        _codigoLivro = codigoLivro;
    }
    public void Executar()
    {
        Console.WriteLine("Livro");
    }
}