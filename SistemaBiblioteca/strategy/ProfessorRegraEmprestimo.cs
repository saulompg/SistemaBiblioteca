using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.strategy;

internal class ProfessorRegraEmprestimo : IRegraEmprestimoStrategy
{
    public void Verificar(Usuario usuario, Livro livro, out string motivo)
    {
        // 1. Verifica se há exemplares disponíveis na biblioteca
        Exemplar? exemplar = livro.BuscaExemplarDisponivel();
        if (exemplar == null)
        {
            motivo = "Não foi possível realizar o empréstimo, não há exemplares disponíveis.";
            return;
        }
        
        // 2. Verifica se há empréstimos em atraso
        if (usuario.EmprestimosAtuais.Exists(e => e.DataDevolucaoPrevista < DateTime.Today && !e.Exemplar.Disponivel))
        {
            motivo = "Não foi possível realizar o empréstimo, existem emprestimos em atrazo.";
            return;
        }
        
        // Empréstimo concluído 
        exemplar.Emprestar(usuario);
        motivo = $"O livro '{livro.Titulo}' foi emprestado a {usuario.Nome}";
        return;
    }
}