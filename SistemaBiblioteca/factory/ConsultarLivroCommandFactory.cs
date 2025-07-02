using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

internal class ConsultarLivroCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 2) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new ConsultarLivroCommand(args[1]);
    }
}