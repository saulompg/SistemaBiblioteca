using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

internal class DevolverCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 3) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new DevolverCommand(args[1], args[2]);
    }
}