namespace ProjetoBiblioteca.strategy
{
    internal class EmprestimoProfessor : IRegraEmprestimo
    {
        public void VerificaEmprestimo()
        {
            /**
             * O empréstimo do livro só será concretizado para um professor se: 
             * 1. Houver a disponibilidade de algum exemplar daquele livro na biblioteca; e 
             * 2. O usuário não estiver como “devedor” de um livro em atraso. 
             **/
        }
    }
}
