using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class EmprestarCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoUsuario;
    private string _codigoLivro;

    public EmprestarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }

    public void Execute(out string output)
    {
        Usuario usuario = _repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = _repo.BuscarLivroPorCodigo(_codigoLivro);
        usuario.RegraEmprestimo.Verificar(usuario, livro, out output);
    }
}