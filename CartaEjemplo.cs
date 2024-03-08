namespace CartaBaseDeDatos;

public class Carta
{
    public string Nombre { get; protected set; }

    public Carta(string Nombre)
    {
        this.Nombre = Nombre;
    }

    public override string ToString()
    {
        return Nombre;
    }
}

public class CartaClima : Carta
{
    public string Efecto;

    public CartaClima(string nombre, string efecto) : base(nombre)
    {
        Efecto = efecto;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Efecto}";
    }
    
}

public class CartaUnidad : Carta
{
    public string Tipo;
    public int Poder;
    public string Efecto;
    public string Clase;
    public string Faccion;

    public CartaUnidad(string nombre, string tipo, int poder, string efecto, string clase, string faccion) : base(nombre)
    {
        Tipo = tipo;
        Poder = poder;
        Efecto = efecto;
        Clase = clase;
        Faccion = faccion;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Tipo}\t{Poder}\t{Efecto}\t{Clase}\t{Faccion}";
    }
}

public class CartaLider : Carta
{
    public string Efecto;
    public string Faccion;

    public CartaLider(string nombre, string efecto, string faccion) : base(nombre)
    {
        Efecto = efecto;
        Faccion = faccion;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Efecto}\t{Faccion}";
    }

}

public class CartaAumento : Carta
{
    public string Efecto;

    public CartaAumento(string nombre, string efecto) : base(nombre)
    {
        Efecto = efecto;
    }

    public override string ToString()
    {
        return $"{Nombre}\t{Efecto}";
    }
}
// public class Carta
//  {
//     public string Nombre;
//     public string Efecto;

//     public CartaNeutral(string nombre, string efecto)
//     {
//         Nombre = nombre;
//         Efecto = efecto;
//     }
// }

