using System;

class BonusScore
{
    static void Main()
    {
        Console.Write("Enter a score in the range [1…9] : ");
        int n = int.Parse(Console.ReadLine());
        if (1 <= n & n <= 9)
        {
            if (1 <= n & n <= 3)
            {
                int score = n * 10;
                Console.WriteLine("Your score is : {0}", score);
            }
            if (4 <= n & n <= 6)
            {
                int score = n * 100;
                Console.WriteLine("Your score is : {0}", score);
            }
            if (7 <= n & n <= 9)
            {
                int score = n * 1000;
                Console.WriteLine("Your score is : {0}", score);
            }
        }
        else
        {
            Console.WriteLine("invalid score");
        }

    }
}

