using System;

class Calculate
{
    static void Main()
    {
        Console.Write("Enter N=");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter K=");
        int K = int.Parse(Console.ReadLine());
        int sum = 1;
        for (int i = K + 1; i <= N; i++)
        {
          sum *= i;
        }
        Console.WriteLine(sum);

    }
}

