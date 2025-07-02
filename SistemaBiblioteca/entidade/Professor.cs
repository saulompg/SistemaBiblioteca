using SistemaBiblioteca.strategy;
using SistemaBiblioteca.observer;

namespace SistemaBiblioteca.entidade
{
    internal class Professor : Usuario, IObservador
    {
        public Professor(string codigo, string nome) : base(codigo, nome) { }
        public override int PrazoEmprestimo { get; } = 8;
        public override IRegraEmprestimoStrategy RegraEmprestimo { get; } = new ProfessorRegraEmprestimo();


        private int _notificacoesRecebidas = 0;
        public int TotalNotificacoesRecebidas => _notificacoesRecebidas;
        public void Notificar(Livro livro)
        {
            _notificacoesRecebidas++;
            //Console.WriteLine($"Professor {Nome} notificado: livro '{livro.Titulo}' possui {livro.Reservas.Count} reservas ativas.");
        }

    }
}
