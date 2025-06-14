using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Reserva
    {
        public Usuario Usuario { get; }
        public Livro Livro { get; }

        public Reserva(Usuario usuario, Livro livro)
        {
            Usuario = usuario;
            Livro = livro;
        }
    }
}
