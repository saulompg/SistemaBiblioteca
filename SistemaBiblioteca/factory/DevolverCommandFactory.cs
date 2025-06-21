using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class DevolverCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new DevolverCommand(args[1], args[2]);
    }
}