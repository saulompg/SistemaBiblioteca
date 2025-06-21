using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.strategy;

internal abstract class AlunoRegraEmprestimo : IRegraEmprestimoStrategy
{
    protected int LimiteEmprestimos { get; set; }
    
    public bool Verificar(Usuario usuario, Livro livro, out string motivo)
    {
        // 1. Verifica se há exemplares disponíveis na biblioteca
        Exemplar? exemplar = livro.BuscaExemplarDisponivel();
        if (exemplar == null)
        {
            motivo = "não há exemplares disponíveis";
            return false;
        }
        
        // 2. Verifica se há empréstimos em atraso
        if (usuario.EmprestimosAtuais.Exists(e => e.DataDevolucao < DateTime.Today && !e.Exemplar.Disponivel))
        {
            motivo = "existem emprestimos em atrazo;";
            return false;
        }

        // 3. Verifica se o usuário está dentro do limite de livros emprestados
        int emprestimosAtivos = usuario.EmprestimosAtuais.Count;
        if (emprestimosAtivos >= LimiteEmprestimos)
        {
            motivo = $"O usuário atingiu o limite de {LimiteEmprestimos} empréstimos;";
            return false;
        }
        
        // 4. Verifica a quantidade de reservas do livro
        //if (usuario.Reservas)      
        
        // 5. Verifica se o usuário possui uma reserva ativa
        
        // 6. Verifica se o usuário já possui um exemplar deste mesmo livro
        
        // Empréstimo concluído 
        motivo = $"O livro {livro.Titulo} foi emprestado a {usuario.Nome}";
        exemplar.EmprestarExemplar(usuario);
        return true;
    }
}