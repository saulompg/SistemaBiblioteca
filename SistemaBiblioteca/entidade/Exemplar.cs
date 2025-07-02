using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.entidade
{
    public class Exemplar
    {
        public string Codigo { get; }
        public Livro Livro { get; }
        public bool Disponivel { get; private set; } = true;
        public Emprestimo? Emprestimo { get; private set; }

        public Exemplar(string codigo, Livro livro)
        {
            Codigo = codigo;
            Livro = livro;
        }

        public void Emprestar(Usuario usuario)
        {
            Emprestimo = new Emprestimo(usuario, this);
            Disponivel = false;
        }

        public void Devolver()
        {
            Emprestimo = null;
            Disponivel = true;
        }

        public string GerarResumo()
        {
            string status = Disponivel ? "Disponível" : "Emprestado";
            string output = $"- Exemplar {Codigo}: {status}\n";

            if (!Disponivel)
            {
                output += $"\t- Usuario: {Emprestimo?.Usuario.Nome}\n";
                output += $"\t- Empréstimo: {Emprestimo?.DataEmprestimo:dd/MM/yyyy}\n";
                output += $"\t- Devolução Prevista: {Emprestimo?.DataDevolucao:dd/MM/yyyy}\n";
            }

            return output;
        }
    }
}
