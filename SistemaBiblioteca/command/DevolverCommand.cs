using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.command;

public class DevolverCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public DevolverCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Repository repo = Repository.Instancia;
        Usuario usuario = repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = repo.BuscarLivroPorCodigo(_codigoLivro);
        usuario.DevolverLivro(livro, out output);
    }
}