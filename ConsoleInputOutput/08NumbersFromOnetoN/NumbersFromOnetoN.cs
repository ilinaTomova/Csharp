using System;

class NumbersFromOnetoN
{
    static void Main()
    {
        Console.Write("Enter a number n in the interval [1..n] :");
        int n = int.Parse(Console.ReadLine());
        if (n > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Not a valid number");
        }
    }
}

