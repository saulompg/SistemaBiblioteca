namespace SistemaBiblioteca
{
    internal class AlunoGraduacao : Usuario
    {
        private readonly int _limiteLivrosEmprestados = 2;

        public AlunoGraduacao(string codigo, string nome) : base(codigo, nome, new EmprestimoAluno())
        {

        }

    }
}
