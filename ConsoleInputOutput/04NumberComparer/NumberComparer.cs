using System;

class NumberComparer
{
    static void Main()
    {
        Console.Write("Enter a number a :");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter a number b :");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(a, b));

    }
}

