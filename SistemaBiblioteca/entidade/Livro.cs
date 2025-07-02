using SistemaBiblioteca.observer;

namespace SistemaBiblioteca.entidade
{
    public class Livro : Topico
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

        public void VerificarReservas()
        {
            if (Reservas.Count > 2)
                NotificarObservadores(this);
        }

        public string GerarResumo()
        {
            // (i) Título
            string output = $"Livro: {Titulo}\n";

            // (ii) Reservas
            int qtdReservas = Reservas.Count;
            output += $"Reservas: {qtdReservas}\n";

            if (qtdReservas > 0)
            {
                output += $"Usuários com reservas:\n";
                foreach (var reservas in Reservas)
                {
                    output += $"- {reservas.Usuario.Nome}\n";
                }
            }

            // (iii) Exemplares
            output += $"Exemplares:\n";
            foreach (var exemplar in Exemplares)
            {
                output += exemplar.GerarResumo();
            }

            return output;
        }
    }
}