namespace ProjetoBiblioteca.entidade
{
    public class Reserva
    {
        public Usuario Usuario { get; }
        public Livro Livro { get; }
        public DateTime DataReserva { get; }

        public Reserva(Usuario usuario, Livro livro)
        {
            Usuario = usuario;
            Livro = livro;
            DataReserva = DateTime.Now;
        }
    }
}
