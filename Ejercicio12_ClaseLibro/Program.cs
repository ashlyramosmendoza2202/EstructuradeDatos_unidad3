using System;

class Libro
{
    public string titulo;

    public void ImprimirTitulo()
    {
        Console.WriteLine("Título del libro: " + titulo);
    }
}

class Program
{
    static void Main()
    {
        Libro miLibro = new Libro();
        miLibro.titulo = "Maria la Ciguapa";
        miLibro.ImprimirTitulo();
    }
}