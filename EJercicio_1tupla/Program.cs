using System;

class SumaNumeros
{
    static void Main()
    {
        Console.WriteLine("_________ Este es un Programa que Suma dos numeros _________");
        Console.WriteLine(" ");

        int PrimerValor;
        int SegundoValor;
        int Resultado;

        Console.WriteLine("Introduce el primer valor: ");
        PrimerValor = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Introduce tu segundo valor: ");
        SegundoValor = Convert.ToInt32(Console.ReadLine());

        Resultado = PrimerValor + SegundoValor;

        Console.WriteLine("La suma de " + PrimerValor + " + " + SegundoValor + " es " + Resultado);
    }
}