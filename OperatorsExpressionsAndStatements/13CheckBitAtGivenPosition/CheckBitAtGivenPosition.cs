using System;

class CheckBitAtGivenPosition
{
    static void Main()
    {

        Console.WriteLine("Enter a number n :");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a number p : ");
        int p = int.Parse(Console.ReadLine());
        bool isOne = (n & (1 << p)) > 0; 
        Console.WriteLine(isOne);
        

    }
}

