using System;

class ExtractBitFromInteger
{
    static void Main()
    {

        Console.WriteLine("Enter a number n :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number p : ");
        int p = int.Parse(Console.ReadLine());
        int nRightP = n >> p;
        int bit = nRightP & 1;
        Console.WriteLine(bit);


    }
}

