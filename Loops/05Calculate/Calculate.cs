using System;

class Calculate
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());

        double factorial = 1;
        double numXPowerN = 1;
        double sumOfSequence = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            numXPowerN *= x;
            sumOfSequence += (factorial / numXPowerN);
        }
        Console.WriteLine("The Sum of sequence of these numbers N and X is SUM = {0:F5} !",
            sumOfSequence);



    }
}

