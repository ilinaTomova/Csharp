using System;
using System.Numerics;
using _07Calculate;
class Calculate
{
    static void Main()
    {
        Console.Write(" n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write(" k = ");
        int k = int.Parse(Console.ReadLine());
        BigInteger chislitel = 1;
        BigInteger znamenatel = 1;
        for (int i = n; i > k; i--)
        {
            chislitel *= i;
        }
        for (int i = 2; i <= (n - k); i++)
        {
            znamenatel *= i;
        }
        BigInteger finalSum = chislitel / znamenatel;
        Console.WriteLine("{0}", finalSum);
    }
}

