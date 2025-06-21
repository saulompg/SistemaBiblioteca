using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class EmprestarCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new EmprestarCommand(args[1], args[2]);
    }
}