using System;

class NumbersFromOnetoN
{
    static void Main()
    {
        Console.Write("Enter a number : ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1; i <= n; i++)
        {
            Console.Write("{0} ", i);
        }
        if (n <= 0)
        {
            Console.WriteLine("Invalid input!!");
        }
    }
}

