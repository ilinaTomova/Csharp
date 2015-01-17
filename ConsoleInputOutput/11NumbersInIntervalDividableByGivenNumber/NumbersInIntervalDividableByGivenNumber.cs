using System;

class NumbersInIntervalDividableByGivenNumber
{
    static void Main()
    {
        Console.Write("Enter two positive numbers, separated by space : ");
        string[] tokens = Console.ReadLine().Split();
        int a = int.Parse(tokens[0]);
        int b = int.Parse(tokens[1]);
        int count = 0;
        if (a >= 0 && b >= 0)
        {
            for (int i = a; i < b; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                    Console.WriteLine(i);
                }
            }
        }
    }
}

