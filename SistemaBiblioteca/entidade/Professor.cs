using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    internal class Professor : Usuario
    {
        public Professor(string codigo, string nome) : base(codigo, nome) { }
        public override int PrazoEmprestimo { get; } = 8;
        public override IRegraEmprestimoStrategy RegraEmprestimo { get; } = new ProfessorRegraEmprestimo();
    }
}
