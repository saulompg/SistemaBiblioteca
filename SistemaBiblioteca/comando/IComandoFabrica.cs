namespace ProjetoBiblioteca.comando;

public interface IComandoFabrica
{
    IComando Criar(string[] args);
}