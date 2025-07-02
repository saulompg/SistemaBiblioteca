using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

internal class ConsultarNotificacaoCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 2) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new ConsultarNotificacaoCommand(args[1]);
    }
}