using SistemaBiblioteca.entidade;
using SistemaBiblioteca.observer;

namespace SistemaBiblioteca.command;

public class ObservarCommand : ICommand
{
    private string _codigoUsuario;
    private string _codigoLivro;
    public ObservarCommand(string codigoUsuario, string codigoLivro)
    {
        _codigoUsuario = codigoUsuario;
        _codigoLivro = codigoLivro;
    }
    public void Execute(out string output)
    {
        Repository repo = Repository.Instancia;
        Usuario usuario = repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        Livro livro = repo.BuscarLivroPorCodigo(_codigoLivro);

        if (usuario is not IObservador)
        {
            output = "Este usu�rio n�o tem permiss�o para ser observador";
            return;
        }

        livro.AdicionarObservador((IObservador) usuario);
        output = $"{usuario.Nome} agora est� observando o livro '{livro.Titulo}'";
    }
}