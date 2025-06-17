using SistemaBiblioteca;

Repositorio rep = Repositorio.GetInstancia();
Usuario usuario = rep.BuscarUsuarioPorCodigo("123");
Console.WriteLine(usuario.Nome);