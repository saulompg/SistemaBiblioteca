namespace ProjetoBiblioteca.comando;

public class ReservarComando : IComando
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public ReservarComando(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Executar()
    {
        Console.WriteLine("Livro reservado");
    }
}