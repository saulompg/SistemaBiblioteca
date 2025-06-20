namespace ProjetoBiblioteca.entidade
{
    internal class Repositorio
    {
        private static Repositorio? _instancia;
        private readonly Dictionary<string, Usuario> _usuarios = new();
        private readonly Dictionary<string, Livro> _livros = new();

        private Repositorio()
        {
            RepositorioUsuarios();
            RepositorioLivros();
        }

        public static Repositorio GetInstancia()
        {
            return _instancia ??= new Repositorio();
        }

        public Usuario BuscarUsuarioPorCodigo(string codigo)
        {
            return _usuarios[codigo];
        }

        public Livro BuscarLivroPorCodigo(string codigo)
        {
            return _livros[codigo];
        }

        private void RepositorioUsuarios ()
        {
            _usuarios["123"] = new AlunoGraduacao("123", "João da Silva");
            _usuarios["456"] = new AlunoPosGraduacao("456", "Luiz Fernando Rodrigues");
            _usuarios["789"] = new AlunoGraduacao("789", "Pedro Paulo");
            _usuarios["100"] = new Professor("100", "Carlos Lucena");
        }

        private void RepositorioLivros() 
        {
            _livros["100"] = new Livro("100", "Engenharia de Software", "Addison Wesley");
            _livros["101"] = new Livro("101", "UML - Guia do Usuário", "Campus");
            _livros["200"] = new Livro("200", "Code Complete", "Microsoft Press");
            _livros["201"] = new Livro("201", "Agile Software Development, Principles, Patterns and Practices", "Microsoft Press");
        }
    }
}
