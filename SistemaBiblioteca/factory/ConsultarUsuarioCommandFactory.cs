using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

internal class ConsultarUsuarioCommandFactory : ICommandFactory
{
    public ICommand Criar(string[] args)
    {
        if (args.Length < 2) throw new IndexOutOfRangeException("Os parâmetros passados para o comando não estão corretos");
        return new ConsultarUsuarioCommand(args[1]);
    }
}