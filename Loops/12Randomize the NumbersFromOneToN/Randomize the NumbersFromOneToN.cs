using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number n : ");
        int n = int.Parse(Console.ReadLine());
        int minN = 1;
        if (n > 0)
        {
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(random.Next(minN, n + 1) + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }

    }
}

