using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.command;

public class ConsultarLivroCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoLivro;
    public ConsultarLivroCommand(string codigoLivro)
    {
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Livro livro = _repo.BuscarLivroPorCodigo(_codigoLivro);
        output = livro.GerarResumo();
    }
}