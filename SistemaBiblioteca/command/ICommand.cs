namespace ProjetoBiblioteca.command;

public interface ICommand
{
    public void Execute(out string output);
}