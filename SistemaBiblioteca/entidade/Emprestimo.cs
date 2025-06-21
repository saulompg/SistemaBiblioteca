namespace ProjetoBiblioteca.entidade
{
    public class Emprestimo
    {
        public Usuario Usuario { get; }
        public Exemplar Exemplar { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime DataDevolucao { get; }

        public Emprestimo( Usuario usuario, Exemplar exemplar)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            DataEmprestimo = DateTime.Now;
            DataDevolucao = DataEmprestimo.AddDays(Usuario.PrazoEmprestimo);
        }
        
    }
}
