using System;

class BitwiseExtractBitThree
{
    static void Main()
    {
        Console.WriteLine("Enter a number n : ");
        int n = int.Parse(Console.ReadLine()); 
        int p = 3;                     
        int nRightP = n >> p;      
        int bit = nRightP & 1;     
        Console.WriteLine(bit);    
  }
}

