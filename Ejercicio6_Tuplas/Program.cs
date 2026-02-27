using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce los grados Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        double fahrenheit = ConvertirAFahrenheit(celsius);

        Console.WriteLine($"{celsius}°C equivalen a {fahrenheit}°F");
    }
    static double ConvertirAFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }
}
