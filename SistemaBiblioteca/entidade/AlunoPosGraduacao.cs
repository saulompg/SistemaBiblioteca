using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    internal class AlunoPosGraduacao : Usuario
    {
        public AlunoPosGraduacao(string codigo, string nome) : base(codigo, nome) { }
        public override int PrazoEmprestimo { get; } = 5;
        public override IRegraEmprestimoStrategy RegraEmprestimo { get; } = 
            new AlunoPosRegraEmprestimo();
    }
}
