using System;
using System.Linq;

public class Programa
{
    public static void Main()
    {
        int[] arr = { 20, 15, 10, 1, 5 };

        Console.WriteLine($"El número mínimo es {arr.Min()}");
        Console.WriteLine($"El número máximo es {arr.Max()}");
    }
}