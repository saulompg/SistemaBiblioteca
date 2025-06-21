using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ConsultarUsuarioCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new ConsultarUsuarioCommand(args[1]);
    }
}