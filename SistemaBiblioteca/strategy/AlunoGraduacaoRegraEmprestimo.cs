namespace ProjetoBiblioteca.strategy;

internal class AlunoGraduacaoRegraEmprestimo : AlunoRegraEmprestimo
{
     public AlunoGraduacaoRegraEmprestimo()
     {
          LimiteEmprestimos = 2;
     }
}