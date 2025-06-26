using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class EmprestarCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 3) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new EmprestarCommand(args[1], args[2]);
    }
}