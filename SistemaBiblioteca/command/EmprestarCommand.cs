using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class EmprestarCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public EmprestarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Repository repo = Repository.Instancia;
        Usuario usuario = repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = repo.BuscarLivroPorCodigo(_codigoLivro);
        usuario.RegraEmprestimo.Verificar(usuario, livro, out output);
    }
}