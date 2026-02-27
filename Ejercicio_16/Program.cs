using System;
using System.Runtime.CompilerServices; 

class Program
{
    static void Main()
    {
        ITuple tupla = (10, 20, 30, 40, 50);
        Console.WriteLine("La longitud de la tupla es: " + tupla.Length);
    }
}
