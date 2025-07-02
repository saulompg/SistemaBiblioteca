using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

internal class SairCommandFactory : ICommandFactory
{
    private readonly Action _sair;
    
    public SairCommandFactory(Action sair)
    {
        _sair = sair;
    }
    
    public ICommand Criar(string[] args)
    {
        return new SairCommand(_sair);
    }
}