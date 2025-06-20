using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    internal class AlunoPosGraduacao : Usuario
    {
        private readonly int _limiteLivrosEmprestados = 3;

        public AlunoPosGraduacao(string codigo, string nome) : base(codigo, nome, new EmprestimoAluno())
        {

        }

    }
}
