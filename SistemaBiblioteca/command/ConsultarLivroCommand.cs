using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class ConsultarLivroCommand : ICommand
{
    private string _codigoLivro;
    public ConsultarLivroCommand(string codigoLivro)
    {
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Repository repo = Repository.Instancia;
        Livro livro = repo.BuscarLivroPorCodigo(_codigoLivro);
        output = livro.Titulo;
    }
}