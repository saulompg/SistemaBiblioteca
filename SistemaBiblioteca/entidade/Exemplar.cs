using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.entidade
{
    internal class Exemplar
    {
        public Livro Livro { get; }
        public Emprestimo? Emprestimo { get; set; }

        public Exemplar(Livro livro) => Livro = livro;
    }
}
