using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repositorio rep = Repositorio.GetInstancia();
            Usuario u = rep.BuscarUsuarioPorCodigo("123");
            Console.WriteLine(u.Nome);
        }
    }
}
