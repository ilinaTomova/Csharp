using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter a number n : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (n >= 1 && n <= 20)
            for (int row = 1; row <= n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write(row + column + " ");
                }
                Console.WriteLine();
            }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}


