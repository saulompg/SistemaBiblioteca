namespace SistemaBiblioteca.command;

public class CommandInvoker
{
    private CommandRegistry _commandRegistry;

    public CommandInvoker(CommandRegistry commandRegistry)
    {
        _commandRegistry = commandRegistry;
    }

    public void ExecutarComando(string input, out string output)
    {
        _commandRegistry.BuscarComando(input).Execute(out output);
    }
}