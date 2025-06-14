using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Emprestimo
    {
        public Usuario Usuario { get; }
        public Exemplar Exemplar { get; }

        public Emprestimo( Usuario usuario, Exemplar exemplar)
        {
            Usuario = usuario;
            Exemplar = exemplar;
        }
    }
}
