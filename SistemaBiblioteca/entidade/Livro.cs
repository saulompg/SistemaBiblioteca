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
        public List<Exemplar> Exemplares { get; } = new();
        public List<Reserva> Reservas { get; } = new();
        public Livro(string codigo, string titulo, string editora, string[] autores, string edicao, int anoPublicacao)
        {
            Codigo = codigo;
            Titulo = titulo;
            Editora = editora;
            Autores = autores;
            Edicao = edicao;
            AnoPublicacao = anoPublicacao;
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