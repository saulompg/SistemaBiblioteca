using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ReservarCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new ReservarCommand(args[1], args[2]);
    }
}