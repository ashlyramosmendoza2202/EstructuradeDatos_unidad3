using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingresa el primer número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        int mayor = EncontrarMayor(n1, n2);

        Console.WriteLine($"El número mayor es: {mayor}");
    }
    static int EncontrarMayor(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}