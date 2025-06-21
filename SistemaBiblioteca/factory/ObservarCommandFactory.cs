using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ObservarCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new ObservarCommand(args[1], args[2]);
    }
}