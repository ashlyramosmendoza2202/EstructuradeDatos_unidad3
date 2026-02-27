using System;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int> { 5, 12, 8, 19, 33 };

        Console.Write("Introduce el número que buscas: ");
        int busqueda = Convert.ToInt32(Console.ReadLine());

        if (ExisteEnLista(numeros, busqueda))
        {
            Console.WriteLine($"¡Sí! El {busqueda} está en la lista.");
        }
        else
        {
            Console.WriteLine($"No, el {busqueda} no se encuentra en la lista.");
        }
    }
    static bool ExisteEnLista(List<int> lista, int numero)
    {
        return lista.Contains(numero);
    }
}