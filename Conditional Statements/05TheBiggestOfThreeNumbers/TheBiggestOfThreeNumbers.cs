using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        Console.WriteLine("Enter numbers a, b , c :");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
 
        if (a > b & a > c) 
        {
            Console.WriteLine("The biggest is {0}" , a);
        }
        if (b > a & b > c)
        {
            Console.WriteLine("The biggest is {0}", b);
        }
        if (c > b & c > a)
        {
            Console.WriteLine("The biggest is {0}", c);
        }
    }
}

