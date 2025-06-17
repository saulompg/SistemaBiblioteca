namespace SistemaBiblioteca
{
    internal class Exemplar
    {
        public Livro Livro { get; }
        public Emprestimo? Emprestimo { get; set; }

        public Exemplar(Livro livro) => Livro = livro;
    }
}
