using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.strategy;

public interface IRegraEmprestimoStrategy
{
    public void Verificar(Usuario usuario, Livro livro, out string motivo);
}