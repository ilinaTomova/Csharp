using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.Write("Enter number a :");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter number b :");
        int b = int.Parse(Console.ReadLine());
        if (a > b)
        {
            Console.WriteLine("{0} {1}", b, a);
        }
        else if (a < b)
        {
            Console.WriteLine("{0} {1}", a, b);
        }
        else if (a == b)
        {
            Console.WriteLine("Hey! Please enter diferent numbers");
        }
    }
}

