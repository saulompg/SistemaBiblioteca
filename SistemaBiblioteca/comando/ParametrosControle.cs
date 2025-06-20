namespace ProjetoBiblioteca.comando;

public class ParametrosControle
{
    public string Parametro1 { get; }
    public string Parametro2 { get; }

    public ParametrosControle(string parametro1)
    {
        Parametro1 = parametro1;
    }
    
    public ParametrosControle(string parametro1, string parametro2)
    {
        Parametro1 = parametro1;
        Parametro2 = parametro2;
    }
}