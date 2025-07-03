namespace SistemaBiblioteca.entidade
{
    public class Emprestimo
    {
        public Usuario Usuario { get; }
        public Exemplar Exemplar { get; }
        public DateTime DataEmprestimo { get; }
        public DateTime DataDevolucaoPrevista { get; }
        public DateTime DataDevolucao { get; private set; }

        public Emprestimo( Usuario usuario, Exemplar exemplar)
        {
            Usuario = usuario;
            Exemplar = exemplar;
            DataEmprestimo = DateTime.Now;
            DataDevolucaoPrevista = DataEmprestimo.AddDays(Usuario.PrazoEmprestimo);
            
            Usuario.AdicionarEmprestimo(this);
        }

        public void DevolverExemplar()
        {
            DataDevolucao = DateTime.Now;
            Exemplar.Devolver();
        }
    }
}
