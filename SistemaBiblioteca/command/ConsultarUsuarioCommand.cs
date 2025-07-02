using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class ConsultarUsuarioCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoUsuario;
    public ConsultarUsuarioCommand(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    
    public void Execute(out string output)
    {
        Usuario usuario = _repo.BuscarUsuarioPorCodigo(_codigoUsuario);
        output = usuario.GerarResumo();
    }
}