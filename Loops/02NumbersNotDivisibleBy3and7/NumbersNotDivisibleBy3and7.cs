using System;

class NumbersNotDivisibleBy3and7
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            if (i % 7 == 0 || i % 3 == 0)
            {
                continue;
            }
            Console.Write("{0} ", i);
        }
    }
}
