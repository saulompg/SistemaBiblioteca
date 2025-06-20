namespace ProjetoBiblioteca.entidade
{
    internal class Emprestimo
    {
        public Usuario Usuario { get; }
        public Exemplar Exemplar { get; }

        public Emprestimo( Usuario usuario, Exemplar exemplar)
        {
            Usuario = usuario;
            Exemplar = exemplar;
        }
    }
}
