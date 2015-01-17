using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter a binary integer number : ");
        string binaryNum = Console.ReadLine();
        long decimalNum = Convert.ToInt64(binaryNum, 2);
        Console.WriteLine("Number in decimal form is : {0}", decimalNum);        
    }
}

