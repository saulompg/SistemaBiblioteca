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
            motivo = "Não foi possível realizar o empréstimo, não há exemplares disponíveis.";
            return false;
        }
        
        // 2. Verifica se há empréstimos em atraso
        if (usuario.EmprestimosAtuais.Exists(e => e.DataDevolucao < DateTime.Today && !e.Exemplar.Disponivel))
        {
            motivo = "Não foi possível realizar o empréstimo, existem emprestimos em atrazo.";
            return false;
        }

        // 3. Verifica se o usuário está dentro do limite de livros emprestados
        int emprestimosAtivos = usuario.EmprestimosAtuais.Count;
        if (emprestimosAtivos >= LimiteEmprestimos)
        {
            motivo = $"Não foi possível realizar o empréstimo, o usuário atingiu o limite de {LimiteEmprestimos} empréstimos.";
            return false;
        }
        
        // 4. Verifica a quantidade de reservas do livro
        // 5. Verifica se o usuário possui uma reserva ativa
        if (livro.Reservas.Count >= livro.Exemplares.Where(e => e.Disponivel).ToList().Count && !usuario.Reservas.Exists(r => r.Livro == livro))
        {
            motivo = $"Não foi possível realizar o empréstimo, os exemplares do livro encontram-se reservados.";
            return false;
        } 
        
        // 6. Verifica se o usuário já possui um exemplar deste mesmo livro
        if (usuario.EmprestimosAtuais.Exists(e => e.Exemplar.Livro == livro))
        {
            motivo = $"Não foi possível realizar o empréstimo, o usuário já possui um exemplar deste livro.";
            return false;
        }
        
        // Empréstimo concluído 
        motivo = $"O livro '{livro.Titulo}' foi emprestado a {usuario.Nome}";
        exemplar.Emprestar(usuario);
        return true;
    }
}