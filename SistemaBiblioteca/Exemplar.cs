using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Exemplar
    {
        public Livro Livro { get; }
        public Emprestimo? Emprestimo { get; set; }

        public Exemplar(Livro livro) => Livro = livro;
    }
}
