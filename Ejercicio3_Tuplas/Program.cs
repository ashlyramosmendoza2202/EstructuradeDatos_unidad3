using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double resultado = CalcularArea(radio);

        Console.WriteLine($"El área del círculo es: {resultado}");
    }
    static double CalcularArea(double r)
    {
        return Math.PI * Math.Pow(r, 2);
    }
}