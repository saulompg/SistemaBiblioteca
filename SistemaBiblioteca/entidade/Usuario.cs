using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    public abstract class Usuario
    {
        public string Codigo { get; }
        public string Nome { get; }
        public List<Emprestimo> EmprestimosAtuais { get; }
        public List<Emprestimo> EmprestimosPassados { get; }
        public List<Reserva> Reservas { get; }
        public abstract int PrazoEmprestimo { get; }
        public abstract IRegraEmprestimoStrategy RegraEmprestimo { get; }

        public Usuario(string codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
            EmprestimosAtuais = [];
            EmprestimosPassados = [];
            Reservas = [];
        }
        public void AdicionarEmprestimo(Emprestimo emprestimo) => EmprestimosAtuais.Add(emprestimo);

        public void AdicionarReserva(Reserva reserva) => Reservas.Add(reserva);

        public override string ToString() => Nome;
    }
}