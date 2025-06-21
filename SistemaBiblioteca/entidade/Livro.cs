using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.entidade
{
    public class Livro
    {
        public string Codigo { get; }
        public string Titulo { get; }
        public string Editora { get; }
        public string[] Autores { get; }
        public string Edicao { get; }
        public int AnoPublicacao { get; }
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

        public void AdicionarExemplar(string codigoExemplar)
        {
            Exemplares.Add(new Exemplar(codigoExemplar, this));
        }

        public Exemplar? BuscaExemplarDisponivel()
        {
            return Exemplares.FirstOrDefault(exemplar => exemplar.Disponivel);
        }

    }
}