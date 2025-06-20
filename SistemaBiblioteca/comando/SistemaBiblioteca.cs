namespace ProjetoBiblioteca.comando;

public class SistemaBiblioteca
{
    private readonly Dictionary<string, Func<string[], IComando>> _registrador = new();

    public void Adicionar(string cmd, Func<string[], IComando> fabrica)
    {
        _registrador[cmd] = fabrica;
    }

    public IComando BuscarComando(string input)
    {
        var args = input.Split(" ");
        var cmd = args[0];
        if (!_registrador.TryGetValue(cmd, out var fabrica))
            throw new InvalidOperationException($"Comando desconhecido: {cmd}");
        return fabrica(args);
    }

    public void ExecutarComando(string input)
    {
        BuscarComando(input).Executar();
    }
}