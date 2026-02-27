using System;
using System.Linq; 

class Program
{
    static void Main()
    {
        var numeros = (1, 2, 2, 3, 2, 4);
        int objetivo = 2;

        int total = new[] { numeros.Item1, numeros.Item2, numeros.Item3, numeros.Item4, numeros.Item5, numeros.Item6 }
                    .Count(n => n == objetivo);

        Console.WriteLine($"El número {objetivo} aparece {total} veces.");
    }
}