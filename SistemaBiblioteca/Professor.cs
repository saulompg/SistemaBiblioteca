namespace SistemaBiblioteca
{
    internal class Professor : Usuario
    {
        public Professor(string codigo, string nome) : base(codigo, nome, new EmprestimoProfessor())
        {
        }
    }
}
