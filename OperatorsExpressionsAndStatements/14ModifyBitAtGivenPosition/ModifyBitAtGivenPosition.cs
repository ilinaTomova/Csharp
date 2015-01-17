using System;
class ModifyBitAtGivenPosition
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());
        int v = int.Parse(Console.ReadLine());
        
        int mask = 1 << p;
        if (v == 1)
        {
            n = n | mask;
        }
        else
        {
            if ((n & mask) == mask)
            {
                n = n ^ mask;
            }
        }
        Console.WriteLine("n={0}", n);

    }
}

