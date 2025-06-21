using ProjetoBiblioteca.command;

namespace ProjetoBiblioteca.factory;

public interface ICommandFactory
{
    public ICommand Criar(string[] args);
}