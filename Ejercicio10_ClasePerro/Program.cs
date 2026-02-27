using System;

class Perro
{
    public string raza;

    public void ImprimirRaza()
    {
        Console.WriteLine("La raza es: " + raza);
    }
}

class Program
{
    static void Main()
    {
        Perro miPerro = new Perro();
        miPerro.raza = "Chihuahua";
        miPerro.ImprimirRaza();
    }
}