using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ConsultarNotificacaoCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new ConsultarNotificacaoCommand(args[1]);
    }
}