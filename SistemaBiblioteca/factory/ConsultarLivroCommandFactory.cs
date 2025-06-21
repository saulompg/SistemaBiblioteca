using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ConsultarLivroCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        return new ConsultarLivroCommand(args[1]);
    }
}