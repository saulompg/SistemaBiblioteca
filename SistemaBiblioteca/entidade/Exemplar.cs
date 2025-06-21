using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.entidade
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

        public void EmprestarExemplar(Usuario usuario)
        {
            Emprestimo emprestimo = new Emprestimo(usuario, this);
            usuario.AdicionarEmprestimo(emprestimo);
            Disponivel = false;
        }
    }
}
