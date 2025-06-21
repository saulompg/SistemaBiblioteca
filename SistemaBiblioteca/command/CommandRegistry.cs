using ProjetoBiblioteca.factory;

namespace ProjetoBiblioteca.command;

public class CommandRegistry
{
    private readonly Dictionary<string, ICommandFactory> _registrador = new();

    public void AdicionarComando(string cmd, ICommandFactory fabrica)
    {
        _registrador[cmd] = fabrica;
    }

    public ICommand BuscarComando(string input)
    {
        var args = input.Split(" ");
        var cmd = args[0];
        if (!_registrador.TryGetValue(cmd, out var fabrica))
            throw new InvalidOperationException($"Comando desconhecido: {cmd}");
        return fabrica.Criar(args);
    }
}