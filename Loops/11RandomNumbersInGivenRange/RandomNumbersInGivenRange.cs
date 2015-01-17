using System;

class RandomNumbersInGivenRange
{
    static void Main(string[] args)
    {
        Console.Write("Enter number n : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min : ");
        int minN = int.Parse(Console.ReadLine());
        Console.Write("Enter max: ");
        int maxN = int.Parse(Console.ReadLine());
         
        if (minN < maxN)
        {
            Random random = new Random();
            for (int i = 1; i <= n; i++)
            {
                Console.Write(random.Next(minN, maxN + 1) + " ");

            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid input!");
        }
    }
}

