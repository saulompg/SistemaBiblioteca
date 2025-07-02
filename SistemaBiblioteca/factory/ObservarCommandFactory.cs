using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

internal class ObservarCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 3) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new ObservarCommand(args[1], args[2]);
    }
}