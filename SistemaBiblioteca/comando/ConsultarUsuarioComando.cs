using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.comando;

public class ConsultarUsuarioComando : IComando
{
    private string _codigoUsuario;
    public ConsultarUsuarioComando(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    
    private readonly Repositorio _db = Repositorio.GetInstancia();
    public void Executar()
    {
        Usuario usuario = _db.BuscarUsuarioPorCodigo(_codigoUsuario);
        Console.WriteLine(usuario);
    }
}