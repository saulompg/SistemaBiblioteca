namespace SistemaBiblioteca.strategy;

internal class AlunoGraduacaoRegraEmprestimo : AlunoRegraEmprestimo
{
     public AlunoGraduacaoRegraEmprestimo()
     {
          LimiteEmprestimos = 2;
     }
}