using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class DevolverCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoUsuario;
    private string _codigoLivro;

    public DevolverCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }

    public void Execute(out string output)
    {
        Usuario usuario = _repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = _repo.BuscarLivroPorCodigo(_codigoLivro);

        usuario.DevolverLivro(livro, out output);
    }
}