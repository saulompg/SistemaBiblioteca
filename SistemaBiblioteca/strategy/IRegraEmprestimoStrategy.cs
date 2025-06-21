using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca.strategy;

public interface IRegraEmprestimoStrategy
{
    public bool Verificar(Usuario usuario, Livro livro, out string motivo);
}