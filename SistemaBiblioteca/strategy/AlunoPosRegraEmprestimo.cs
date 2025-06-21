namespace ProjetoBiblioteca.strategy;

internal class AlunoPosRegraEmprestimo : AlunoRegraEmprestimo
{
    public AlunoPosRegraEmprestimo()
    {
        LimiteEmprestimos = 3;
    }
}