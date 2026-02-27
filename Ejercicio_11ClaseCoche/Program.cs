using System;

class Coche
{
    public string color;

    public string ObtenerColor()
    {
        return color;
    }
}

class Program
{
    static void Main()
    {
        Coche miCoche = new Coche();
        miCoche.color = "Azul";
        Console.WriteLine("El color del coche es: " + miCoche.ObtenerColor());
    }
}
