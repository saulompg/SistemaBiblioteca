using SistemaBiblioteca.strategy;

namespace SistemaBiblioteca.entidade
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
            Reservas.FirstOrDefault(r => r.Livro == emprestimo.Exemplar.Livro)?.CancelarReserva();
            EmprestimosAtuais.Add(emprestimo);
        }

        public void ReservarLivro(Livro livro, out string output)
        {
            if (Reservas.Exists(r => r.Livro.Titulo == livro.Titulo))
            {
                output = $"O Usuário já possui reserva para este Livro";
                return;
            }
            Reserva reserva = new Reserva(this, livro);
            livro.Reservas.Add(reserva);
            Reservas.Add(reserva);
            output = $"O Livro '{reserva.Livro.Titulo}' foi reservado por {reserva.Usuario.Nome}";
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

        public string GerarResumo()
        {
            string output = "";

            return output;
        }
    }
}