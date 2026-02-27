using System;

class Persona
{
    public string nombre;

    public void Saludar()
    {
        Console.WriteLine("Hola, soy " + nombre);
    }
}

class Program
{
    static void Main()
    {
        Persona p = new Persona();
        p.nombre = "Ashly Ramos";
        p.Saludar();
    }
}
