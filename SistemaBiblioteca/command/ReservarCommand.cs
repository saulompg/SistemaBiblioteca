using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class ReservarCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoUsuario;
    private string _codigoLivro;
    public ReservarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Usuario usuario = _repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = _repo.BuscarLivroPorCodigo(_codigoLivro);
        usuario.ReservarLivro(livro);
        output = $"O Livro '{livro.Titulo}' foi reservado por {usuario.Nome}";
    }
}