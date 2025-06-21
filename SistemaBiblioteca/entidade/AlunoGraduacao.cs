using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    internal class AlunoGraduacao : Usuario
    {
        public AlunoGraduacao(string codigo, string nome) : base(codigo, nome) { }
        public override int PrazoEmprestimo { get; } = 4;

        public override IRegraEmprestimoStrategy RegraEmprestimo { get; } =
            new AlunoGraduacaoRegraEmprestimo();
    }
}
