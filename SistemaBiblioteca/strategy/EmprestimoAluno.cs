namespace ProjetoBiblioteca.strategy
{
    internal class EmprestimoAluno : IRegraEmprestimo
    {
        public void VerificaEmprestimo()
        {
            /**
             * O empréstimo de um livro será realizado para um aluno de graduação ou de pós-graduação apenas se: 
             * 1. Houver exemplares disponíveis na biblioteca;
             * 2. O usuário não estiver “devedor” com livros em atraso; 
             * 3. O usuário seguir as regras específicas referentes à quantidade máxima de livros que podem ser 
             * emprestados (conforme Tabela 2);
             * 4. A quantidade de reservas existentes do livro deve ser menor do que a quantidade de exemplares 
             * disponíveis, desde que o usuário não tenha uma reserva para esse livro; 
             * 5. Se a quantidade de reservas for igual ou superior à de exemplares disponíveis, o empréstimo 
             * será permitido apenas se uma das reservas for do usuário; 
             * 6. O usuário não pode ter nenhum empréstimo em andamento de um exemplar desse mesmo livro.
            **/
        }
    }
}
