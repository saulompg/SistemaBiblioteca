using SistemaBiblioteca.command;

namespace SistemaBiblioteca
{
    public class ConsoleUI
    {
        private readonly CommandInvoker _invoker;
        private bool _executando = true;

        public ConsoleUI(CommandInvoker invoker)
        {
            _invoker = invoker;
        }

        public void Iniciar()
        {
            Console.WriteLine(".: Sistema de Biblioteca Acadêmica :.");

            while (_executando)
            {
                Console.WriteLine("Digite um comando:");
                Console.Write("> ");
                string? input = Console.ReadLine()?.Trim();

                if (string.IsNullOrWhiteSpace(input))
                    continue;

                try
                {
                    _invoker.ExecutarComando(input, out string output);
                    Console.WriteLine(output);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Erro | " + e.Message);
                }
            }

            Console.WriteLine("Programa finalizado.");
        }

        public void Encerrar()
        {
            _executando = false;
        }
    }
}
