using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Repositorio
    {
        private static Repositorio? _instancia;
        private readonly List<Usuario> _usuarios;
        private readonly List<Livro> _livros;

        private Repositorio()
        {
            _usuarios = new List<Usuario>();
            _livros = new List<Livro>();
            PopularListaUsuarios();
            PopularListaLivros();
        }

        public static Repositorio GetInstancia()
        {
            return _instancia ??= new Repositorio();
        }

        public Usuario? BuscarUsuarioPorCodigo(string codigo)
        {
            return _usuarios.FirstOrDefault(u => u.Codigo == codigo);
        }

        public Livro? BuscarLivroPorCodigo(string codigo)
        {
            return _livros.FirstOrDefault(l => l.Codigo == codigo);
        }

        private void PopularListaUsuarios ()
        {
            _usuarios.Add(new AlunoGraduacao("123", "João da Silva"));
            _usuarios.Add(new AlunoPosGraduacao("456", "Luiz Fernando Rodrigues"));
            _usuarios.Add(new AlunoGraduacao("789", "Pedro Paulo"));
            _usuarios.Add(new Professor("100", "Carlos Lucena"));
        }

        private void PopularListaLivros() 
        {
            _livros.Add(new Livro("100", "Engenharia de Software", "Addison Wesley"));
            _livros.Add(new Livro("101", "UML - Guia do Usuário", "Campus"));
            _livros.Add(new Livro("200", "Code Complete", "Microsoft Press"));
            _livros.Add(new Livro("201", "Agile Software Development, Principles, Patterns and Practices", "Microsoft Press"));
        }
    }
}
