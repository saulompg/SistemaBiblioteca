using SistemaBiblioteca.entidade;

namespace SistemaBiblioteca.observer
{
    public class Topico
    {
        private List<IObservador> _observadores = new List<IObservador>();
        public void AdicionarObservador(IObservador observador)
        {
            if (!_observadores.Contains(observador))
                _observadores.Add(observador);
        }
        public void RemoverObservador(IObservador observador)
        {
            _observadores.Remove(observador);
        }
        public void NotificarObservadores(Livro livro)
        {
            foreach (var obs in _observadores)
            {
                obs.Notificar(livro);
            }
        }

    }
}
