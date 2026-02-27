using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var ciudades = ("Madrid", "Bogotá", "CDMX", "Lima", "Santiago");

        List<string> listaCiudades = new List<string> {
            ciudades.Item1, ciudades.Item2, ciudades.Item3, ciudades.Item4, ciudades.Item5
        };

        Console.WriteLine("Primer elemento de la lista: " + listaCiudades[0]);
    }
}
