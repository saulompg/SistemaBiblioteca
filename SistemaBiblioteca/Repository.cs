using ProjetoBiblioteca.entidade;

namespace ProjetoBiblioteca
{
    public class Repository
    {
        private static Repository? _instancia;
        public static Repository Instancia => _instancia ??= new Repository();

        public Dictionary<string, Usuario> Usuarios { get; } = new();
        public Dictionary<string, Livro> Livros { get; } = new();

        private Repository() { }

        public Usuario BuscarUsuarioPorCodigo(string codigo)
        {
            return Usuarios.TryGetValue(codigo, out var usuario) ? usuario
                : throw new InvalidOperationException($"Código [{codigo}] não encontrado");
        }

        public Livro BuscarLivroPorCodigo(string codigo)
        {
            return Livros.TryGetValue(codigo, out var livro) ? livro
                : throw new InvalidOperationException($"Código [{codigo}] não encontrado");
        }

        public void AdicionarUsuario(Usuario usuario) => Usuarios[usuario.Codigo] = usuario;

        public void AdicionarLivro(Livro livro) => Livros[livro.Codigo] = livro;
    }
}
