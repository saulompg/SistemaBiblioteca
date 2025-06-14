namespace SistemaBiblioteca
{
    internal class Livro
    {
        public string Codigo { get; }
        public string Titulo { get; }
        public string Editora { get; }
        public List<Exemplar> Exemplares { get; }
        public List<Reserva> Reservas { get; }
        public Livro(string codigo, string titulo, string editora)
        {
            Codigo = codigo;
            Titulo = titulo;
            Editora = editora;
            Exemplares = new List<Exemplar>();
            Reservas = new List<Reserva>();
        }

    }
}