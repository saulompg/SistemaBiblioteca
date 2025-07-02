using SistemaBiblioteca.command;

namespace SistemaBiblioteca.factory;

public interface ICommandFactory
{
    public ICommand Criar(string[] args);
}