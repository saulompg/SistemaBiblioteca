using SistemaBiblioteca.entidade;
using SistemaBiblioteca.observer;

namespace SistemaBiblioteca.command;

public class ConsultarNotificacaoCommand : ICommand
{
    private readonly Repository _repo = Repository.Instancia;
    private string _codigoUsuario;
    public ConsultarNotificacaoCommand(string codigoUsuario)
    {
        _codigoUsuario = codigoUsuario;
    }
    public void Execute(out string output)
    {
        Usuario usuario = _repo.BuscarUsuarioPorCodigo(_codigoUsuario);

        if (usuario is not IObservador observador)
        {
            output = $"O usuário {usuario.Nome} não recebe notificações";
            return;
        }

        output = $"O Usuário {usuario.Nome} possui {observador.TotalNotificacoesRecebidas} notificações";
    }
}