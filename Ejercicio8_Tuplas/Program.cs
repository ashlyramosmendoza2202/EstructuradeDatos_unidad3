using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe algo para contar sus letras: ");
        string entrada = Console.ReadLine();

        int largo = ObtenerLongitud(entrada);

        Console.WriteLine($"La cadena tiene {largo} caracteres.");
    }

    static int ObtenerLongitud(string texto)
    {
        return texto.Length;
    }
}