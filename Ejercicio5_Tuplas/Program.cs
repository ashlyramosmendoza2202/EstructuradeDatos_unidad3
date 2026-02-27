using System;

class Program
{
    static void Main()
    {
        Console.Write("Escribe una palabra o frase: ");
        string texto = Console.ReadLine();

        int cantidadVocales = ContarVocales(texto);

        Console.WriteLine($"El número total de vocales es: {cantidadVocales}");
    }

    static int ContarVocales(string frase)
    {
        int contador = 0;
        string fraseMinuscula = frase.ToLower();

        foreach (char letra in fraseMinuscula)
        {
            if ("aeiouáéíóú".Contains(letra))
            {
                contador++;
            }
        }

        return contador;
    }
}