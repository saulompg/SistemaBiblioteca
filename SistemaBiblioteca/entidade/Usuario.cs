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
        public void AdicionarEmprestimo(Emprestimo emprestimo)
        {
            Reserva? reserva = Reservas.FirstOrDefault(r => r.Livro == emprestimo.Exemplar.Livro);
            if (reserva != null) Reservas.Remove(reserva);
            EmprestimosAtuais.Add(emprestimo);
        }

        public void ReservarLivro(Livro livro)
        {
            Reserva reserva = new Reserva(this, livro);
            livro.Reservas.Add(reserva);
            Reservas.Add(reserva);
        }

        public void DevolverLivro(Livro livro, out string output)
        {
            Emprestimo? emprestimo = EmprestimosAtuais.FirstOrDefault(e => e.Exemplar.Livro == livro);
            if (emprestimo == null)
            {
                output = $"O livro '{livro.Titulo}' não está cadastrado com este usuário.";
                return;
            }
            emprestimo.DevolverExemplar();
            EmprestimosAtuais.Remove(emprestimo);
            EmprestimosPassados.Add(emprestimo);
            output = $"O Livro '{livro.Titulo}' foi devolvido por {Nome}";
        }
    }
}