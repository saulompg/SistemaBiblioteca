namespace SistemaBiblioteca
{
    internal class Usuario
    {
        public string Codigo { get; }
        public string Nome { get; }
        public List<Emprestimo> EmprestimosAtuais { get; }
        public List<Emprestimo> EmprestimosPassados { get; }
        public List<Reserva> Reservas { get; }

        public Usuario(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            EmprestimosAtuais = new List<Emprestimo>();
            EmprestimosPassados = new List<Emprestimo>();
            Reservas = new List<Reserva>();
        }
    }
}