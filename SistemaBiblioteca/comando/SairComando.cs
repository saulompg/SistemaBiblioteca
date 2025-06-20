namespace ProjetoBiblioteca.comando;

public class SairComando : IComando
{
    private readonly Action _sair;

    public SairComando(Action sair)
    {
        _sair = sair;
    }
    public void Executar()
    {
        Console.WriteLine("Encerrando o Programa...");
        _sair.Invoke();
    }
}