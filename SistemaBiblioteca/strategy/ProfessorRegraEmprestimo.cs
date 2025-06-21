using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.strategy;

internal class ProfessorRegraEmprestimo : IRegraEmprestimoStrategy
{
    public bool Verificar(Usuario usuario, Livro livro, out string motivo)
    {
        throw new NotImplementedException();
    }
}