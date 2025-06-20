using ProjetoBiblioteca.strategy;

namespace ProjetoBiblioteca.entidade
{
    internal class Professor : Usuario
    {
        public Professor(string codigo, string nome) : base(codigo, nome, new EmprestimoProfessor())
        {
        }
    }
}
