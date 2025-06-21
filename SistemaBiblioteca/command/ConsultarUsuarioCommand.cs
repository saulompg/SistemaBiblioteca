using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.command;

public class ConsultarUsuarioCommand : ICommand
{
    private string _codigoUsuario;
    public ConsultarUsuarioCommand(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    
    private readonly Repository _db = Repository.Instancia;
    public void Execute(out string output)
    {
        Usuario usuario = _db.BuscarUsuarioPorCodigo(_codigoUsuario); 
        output = usuario.ToString();
    }
}