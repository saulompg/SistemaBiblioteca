using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.observer
{
    public interface IObservador
    {
        public void Notificar(Livro livro);
        public int TotalNotificacoesRecebidas { get; }
    }
}
